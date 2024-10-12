using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Asociar eventos de la vista con los métodos del presentador
            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            // Asignar la lista de productos a la vista
            this.view.SetProductListBindingSource(productBindingSource);

            // Cargar la lista completa de productos
            LoadAllProductList();

            // Mostrar la vista
            this.view.Show();
        }

        // Cargar todos los productos
        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        // Cancelar la operación
        private void CancelAction(object? sender, EventArgs e)
        {
            LoadAllProductList();
        }

        // Agregar un nuevo producto
        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            LoadAllProductList();
        }

        // Guardar producto (Agregar o Editar)
        private void SaveProduct(object? sender, EventArgs e)
        {
            // Crear un nuevo producto basado en los datos de la vista
            var product = new ProductModel();

            // Validar que los campos no estén vacíos o sean inválidos antes de convertir
            if (!string.IsNullOrWhiteSpace(view.Id) && int.TryParse(view.Id, out int productId))
            {
                product.Product_Id = productId;
            }
            else
            {
                view.Message = "El ID del producto no es válido.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.Price) && decimal.TryParse(view.Price, out decimal productPrice))
            {
                product.Product_Price = productPrice;
            }
            else
            {
                view.Message = "El precio del producto no es válido.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.Stock) && int.TryParse(view.Stock, out int productStock))
            {
                product.Product_Stock = productStock;
            }
            else
            {
                view.Message = "El stock del producto no es válido.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.CategoryId) && int.TryParse(view.CategoryId, out int categoryId))
            {
                product.Category_Id = categoryId;
            }
            else
            {
                view.Message = "El ID de la categoría no es válido.";
                return;
            }

            product.Product_Name = view.Name;

            try
            {
                new Common.ModelDataValidation().Validate(product);

                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Producto editado correctamente.";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Producto añadido correctamente.";
                }

                view.IsSuccessful = true;
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }


        // Eliminar el producto seleccionado
        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Product_Id);
                view.IsSuccessful = true;
                view.Message = "Producto eliminado correctamente.";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar el producto.";
            }
        }

        // Cargar el producto seleccionado para editar
        private void LoadSelectedProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.Id = product.Product_Id.ToString();
            view.Name = product.Product_Name;
            view.Price = product.Product_Price.ToString();
            view.Stock = product.Product_Stock.ToString();
            view.CategoryId = product.Category_Id.ToString();

            view.IsEdit = true;
        }

        // Buscar productos (Por nombre o categoría)
        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                productList = repository.GetByCategory(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}

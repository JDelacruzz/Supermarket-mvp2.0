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

            // Asociar la lista de productos con la vista
            this.view.SetProductListBindingSource(productBindingSource);

            // Cargar todos los productos
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

        // Limpiar los campos de la vista
        private void CleanViewFields()
        {
            view.Id = "0";
            view.Name = "";
            view.Price = "0";
            view.Stock = "0";
            view.CategoryId = "0";
        }

        // Cancelar la operación
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        // Guardar producto (Agregar o Editar)
        private void SaveProduct(object? sender, EventArgs e)
        {
            // Crear un nuevo producto basado en los datos de la vista
            var product = new ProductModel();
            product.Product_Id = Convert.ToInt32(view.Id);
            product.Product_Name = view.Name;
            product.Product_Price = Convert.ToDecimal(view.Price);
            product.Product_Stock = Convert.ToInt32(view.Stock);

            try
            {
                new Common.ModelDataValidation().Validate(product);

                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfully.";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfully.";
                }

                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
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
                view.Message = "Product deleted successfully.";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete the product.";
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

            view.IsEdit = true;
        }

        // Buscar productos (Por nombre o categoría)
        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
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

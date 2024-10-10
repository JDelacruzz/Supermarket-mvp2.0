using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;
using System.Windows.Forms;

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

            // Asociar eventos de la vista a los métodos del presentador
            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            // Establecer el BindingSource
            this.view.SetProductListBindingSource(productBindingSource);

            // Cargar todos los productos al iniciar
            LoadAllProductList();

            this.view.Show();
        }

        // Cargar todos los productos de la base de datos
        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        // Acción para cancelar la operación actual y limpiar los campos
        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        // Guardar producto (agregar o editar)
        private void SaveProduct(object sender, EventArgs e)
        {
            // Crear un nuevo objeto ProductModel y asignar los valores de la vista
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.Id);
            product.Name = view.Name;
            product.Price = Convert.ToDecimal(view.Price);
            product.Stock = Convert.ToInt32(view.Stock);
            product.CategoryId = Convert.ToInt32(view.CategoryId);

            try
            {
                // Validación de datos del producto
                new Common.ModelDataValidation().Validate(product);

                // Verificar si estamos en modo de edición o de nuevo producto
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
                // Manejar cualquier error que ocurra durante el guardado
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
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

        // Eliminar el producto seleccionado
        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully.";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete product.";
            }
        }

        // Cargar el producto seleccionado para editar
        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.Id = product.Id.ToString();
            view.Name = product.Name;
            view.Price = product.Price.ToString();
            view.Stock = product.Stock.ToString();
            view.CategoryId = product.CategoryId.ToString();

            view.IsEdit = true;
        }

        // Buscar productos por valor (ID o nombre)
        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}

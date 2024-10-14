using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Asociar eventos de la vista con los métodos del presentador
            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            // Asignar la lista de categorías a la vista
            this.view.SetCategoryListBindingSource(categoriesBindingSource);

           
            LoadAllCategoryList();

            
            this.view.Show();
        }

        
        private void LoadAllCategoryList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

       
        private void CleanViewFields()
        {
            view.Id = "0";
            view.Name = "";
            view.Description = "";
        }

        
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        
        private void SaveCategory(object? sender, EventArgs e)
        {
            
            var category = new CategoriesModel
            {
                Id = Convert.ToInt32(view.Id),
                Name = view.Name,
                Description = view.Description
            };

            try
            {
                new Common.ModelDataValidation().Validate(category);

                if (view.IsEdit)
                {
                    repository.Edit(category);
                    view.Message = "Category edited successfully.";
                }
                else
                {
                    repository.Add(category);
                    view.Message = "Category added successfully.";
                }

                view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        // Eliminar la categoría seleccionada
        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var category = (CategoriesModel)categoriesBindingSource.Current;
                repository.Delete(category.Id);
                view.IsSuccessful = true;
                view.Message = "Category deleted successfully.";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete the category.";
            }
        }

        // Cargar la categoría seleccionada para editar
        private void LoadSelectedCategoryToEdit(object? sender, EventArgs e)
        {
            var category = (CategoriesModel)categoriesBindingSource.Current;

            view.Id = category.Id.ToString();
            view.Name = category.Name;
            view.Description = category.Description;

            view.IsEdit = true;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        // Buscar categorías (por nombre o descripción)
        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }
    }
}

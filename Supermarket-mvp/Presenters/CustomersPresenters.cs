using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.customersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Asociar eventos de la vista con los métodos del presentador
            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            // Asignar la lista de clientes a la vista
            this.view.SetCustomerListBindingSource(customersBindingSource);

            // Cargar la lista completa de clientes
            LoadAllCustomerList();

            // Mostrar la vista
            this.view.Show();
        }

        // Cargar todos los clientes
        private void LoadAllCustomerList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        // Limpiar los campos de la vista
        private void CleanViewFields()
        {
            view.Id = "0";
            view.DocumentNumber = "";
            view.FirstName = "";
            view.LastName = "";
            view.Address = "";
            view.BirthDay = "";
            view.PhoneNumber = "";
            view.Email = "";
        }

        // Cancelar la operación
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        // Guardar un cliente (Agregar o Editar)
        private void SaveCustomer(object? sender, EventArgs e)
        {
            // Crear un nuevo objeto cliente basado en los datos de la vista
            var customer = new CustomersModel
            {
                Customer_Id = Convert.ToInt32(view.Id),
                Document_Number = view.DocumentNumber,
                First_Name = view.FirstName,
                Last_Name = view.LastName,
                Address = view.Address,
                Birth_Day = view.BirthDay,
                Phone_Number = view.PhoneNumber,
                Email = view.Email
            };

            try
            {
                new Common.ModelDataValidation().Validate(customer);

                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer edited successfully.";
                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added successfully.";
                }

                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        // Eliminar el cliente seleccionado
        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomersModel)customersBindingSource.Current;
                repository.Delete(customer.Customer_Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully.";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete the customer.";
            }
        }

        // Cargar el cliente seleccionado para editar
        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomersModel)customersBindingSource.Current;

            view.Id = customer.Customer_Id.ToString();
            view.DocumentNumber = customer.Document_Number;
            view.FirstName = customer.First_Name;
            view.LastName = customer.Last_Name;
            view.Address = customer.Address;
            view.BirthDay = customer.Birth_Day;
            view.PhoneNumber = customer.Phone_Number;
            view.Email = customer.Email;

            view.IsEdit = true;
        }
        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        // Buscar clientes (por documento o nombre)
        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }
    }
}

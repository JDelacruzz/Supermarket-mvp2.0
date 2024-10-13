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

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBindingSource(customersBindingSource);

            LoadAllCustomerList();

            
            this.view.Show();
        }

        
        private void LoadAllCustomerList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        
        private void ClearSearchField()
        {
            view.SearchValue = string.Empty;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            LoadAllCustomerList();
        }

        
        private void SaveCustomer(object? sender, EventArgs e)
        {
            
            int customerId = 0;
            if (!string.IsNullOrEmpty(view.Id))
            {
                customerId = Convert.ToInt32(view.Id);
            }

            
            var customer = new CustomersModel
            {
                Customer_Id = customerId,
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
                    view.Message = "Cliente editado correctamente.";
                }
                else 
                {
                    repository.Add(customer);
                    view.Message = "Cliente añadido correctamente.";
                }

                view.IsSuccessful = true;
                LoadAllCustomerList();
                ClearSearchField(); 
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomersModel)customersBindingSource.Current;
                repository.Delete(customer.Customer_Id);
                view.IsSuccessful = true;
                view.Message = "Cliente eliminado correctamente.";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar el cliente.";
            }
        }

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
            LoadAllCustomerList();
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
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

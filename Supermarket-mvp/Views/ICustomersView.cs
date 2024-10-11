using System;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    internal interface ICustomersView
    {
        // Propiedades del cliente
        string Id { get; set; }
        string DocumentNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string BirthDay { get; set; }   
        string PhoneNumber { get; set; }
        string Email { get; set; }

        // Propiedad de búsqueda y estado de la vista
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Eventos para las acciones de la vista
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Método para enlazar la lista de clientes a un DataGridView
        void SetCustomerListBindingSource(BindingSource customerList);

        // Método para mostrar la vista
        void Show();
    }
}

using System;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    internal interface ICategoriesView
    {
        // Propiedades de la categoría
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        // Propiedad de búsqueda y estado de la vista
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

     
        void SetCategoryListBindingSource(BindingSource categoryList);

        void Show();
    }
}

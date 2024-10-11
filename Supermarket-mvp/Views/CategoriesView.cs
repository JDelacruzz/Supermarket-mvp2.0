using Supermarket_mvp.Models;
using System;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isSuccessful;
        private bool isEdit;
        private string message;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCategoriesDetail); // Remover la pestaña de detalles al iniciar

            BtnClose.Click += delegate { this.Close(); }; // Evento para cerrar la ventana
        }

        // Asignar eventos a los controles de la vista
        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Evento para agregar una nueva categoría
            BtnNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Add New Categories"; // Cambiar el título de la pestaña
            };

            // Evento para editar la categoría seleccionada
            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Edit Categories"; // Cambiar el título de la pestaña
            };

            // Evento para eliminar la categoría seleccionada
            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Categories?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Evento para guardar la categoría
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful) // Si guardar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                    tabControl1.TabPages.Add(tabPageCategoriesList);
                }
                MessageBox.Show(Message); // Mostrar el mensaje después de guardar
            };

            // Evento para cancelar la operación
            BtnCancelar.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                tabControl1.TabPages.Add(tabPageCategoriesList);
            };
        }

        // Propiedades de la vista

        public string Id
        {
            get { return TxtCategoriesId.Text; }
            set { TxtCategoriesId.Text = value; }
        }

        public string Name
        {
            get { return TxtCategoriesName.Text; }
            set { TxtCategoriesName.Text = value; }
        }

        public string Description
        {
            get { return TxtCategoriesDescription.Text; }
            set { TxtCategoriesDescription.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        // Método para asociar la lista de categorías al DataGridView
        public void SetCategoryListBindingSource(BindingSource categoriesList)
        {
            DgCategories.DataSource = categoriesList;
        }

        // Patrón singleton para controlar solo una instancia del formulario
        private static CategoriesView instance;

        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}

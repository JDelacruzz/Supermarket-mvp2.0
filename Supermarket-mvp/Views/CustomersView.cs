using Supermarket_mvp.Models;
using System;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CustomersView : Form, ICustomersView
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

        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomersDetail); // Remover la pestaña de detalles al iniciar

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

            // Evento para agregar un nuevo cliente
            BtnNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Add New Customer"; // Cambiar el título de la pestaña
            };

            // Evento para editar el cliente seleccionado
            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Edit Customer"; // Cambiar el título de la pestaña
            };

            // Evento para eliminar el cliente seleccionado
            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Customer?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Evento para guardar el cliente
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful) // Si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageCustomersDetail);
                    tabControl1.TabPages.Add(tabPageCustomersList);
                }
                MessageBox.Show(Message); // Mostrar el mensaje después de guardar
            };

            // Evento para cancelar la operación
            BtnCancelar.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersDetail);
                tabControl1.TabPages.Add(tabPageCustomersList);
            };
        }

        // Propiedades de la vista

        public string Id
        {
            get { return TxtCustomersId.Text; }
            set { TxtCustomersId.Text = value; }
        }

        public string DocumentNumber
        {
            get { return TxtCustomersDocument.Text; }
            set { TxtCustomersDocument.Text = value; }
        }

        public string FirstName
        {
            get { return TxtCustomersFirst.Text; }
            set { TxtCustomersFirst.Text = value; }
        }

        public string LastName
        {
            get { return TxtCustomersLast.Text; }
            set { TxtCustomersLast.Text = value; }
        }

        public string Address
        {
            get { return TxtCustomersAddress.Text; }
            set { TxtCustomersAddress.Text = value; }
        }

        public string BirthDay
        {
            get { return TxtCustomersPhone.Text; }
            set { TxtCustomersPhone.Text = value; }
        }

        public string PhoneNumber
        {
            get { return TxtCustomersPhone.Text; }
            set { TxtCustomersPhone.Text = value; }
        }

        public string Email
        {
            get { return TxtCustomersEmail.Text; }
            set { TxtCustomersEmail.Text = value; }
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

        // Método para asociar la lista de clientes al DataGridView
        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            DgCustomers.DataSource = customerList;
        }

        // Patrón singleton para controlar solo una instancia del formulario
        private static CustomersView instance;

        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersView();
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

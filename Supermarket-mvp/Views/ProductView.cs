using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
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

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProductDetail); // Remover la pestaña de detalles al iniciar

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

            // Evento para agregar un nuevo producto
            BtnNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add New Product";

                ClearFields();
            };

            // Evento para editar el producto seleccionado
            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Edit Product"; // Cambiar el título de la pestaña
            };

            // Evento para eliminar el producto seleccionado
            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Evento para guardar el producto
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful) // Si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);

                    ClearFields();
                }
                MessageBox.Show(Message); // Mostrar el mensaje después de guardar
            };

            // Evento para cancelar la operación
            BtnCancelar.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);

                ClearFields();
            };
        }

        // Propiedades de la vista

        public string Id
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }

        public string Name
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }

        public string Price
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value; }
        }

        public string Stock
        {
            get { return TxtProductStock.Text; }
            set { TxtProductStock.Text = value; }
        }

        public string CategoryId
        {
            get { return TxtProductCategoryId.Text; }
            set { TxtProductCategoryId.Text = value; }
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

        public void ClearFields()
        {
            TxtProductName.Text = string.Empty;
            TxtProductPrice.Text = string.Empty;
            TxtProductStock.Text = string.Empty;
            TxtProductCategoryId.Text = string.Empty;
        }

        public void SetProductListBindingSource(BindingSource productList)
        {
            DgProductList.DataSource = productList;
        }

        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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

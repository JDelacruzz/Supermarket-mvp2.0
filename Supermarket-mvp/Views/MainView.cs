namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            BtnCustomers.Click += delegate { ShowCustomersView?.Invoke(this, EventArgs.Empty); };
            BtnCategories.Click += delegate { ShowCategoriesView?.Invoke(this, EventArgs.Empty); };

            BtnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomersView;
        public event EventHandler ShowCategoriesView;
    }
}

using WarehouseManagent.Business;

namespace WarehouseManagent.Forms.Products
{
    public partial class ViewProductsForm : Form
    {
        private ProductBusiness productBusiness;
        public ViewProductsForm()
        {
            InitializeComponent();
            productBusiness = new();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            var products = productBusiness.GetProducts();
            productGridView.DataSource = products;
            productGridView.Columns[0].Visible = false;
        }
    }
}

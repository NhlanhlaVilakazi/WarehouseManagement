using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Products
{
    public partial class ViewProductsForm : Form
    {
        private ProductBusiness productBusiness;
        private HidePrimaryKeyFields keyFields;
        public ViewProductsForm()
        {
            InitializeComponent();
            productBusiness = new();
            keyFields = new();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            var products = productBusiness.GetProducts();
            productGridView.DataSource = products;
            keyFields.HideFields(productGridView, 3);
        }
    }
}

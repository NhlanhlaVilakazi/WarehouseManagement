using WarehouseManagent.Business;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Products
{
    public partial class AddProductForm : Form
    {
        private ProductBusiness productBusiness;
        public AddProductForm()
        {
            InitializeComponent();
            productBusiness = new();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MissingInputs())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool added = productBusiness.AddNewProduct(GetProductModel());
            if (added) MessageBox.Show("Product successfully added!");
            else MessageBox.Show("An error occured while processing the rquest, please try again later..");
        }

        public bool MissingInputs()
        {
            return false;
        }

        public ProductViewModel GetProductModel()
        {
            return new ProductViewModel
            {
               // ProductID = 
            };
        }
    }
}

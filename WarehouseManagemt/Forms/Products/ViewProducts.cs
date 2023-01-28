using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Products
{
    public partial class ViewProductsForm : Form
    {
        private ProductBusiness productBusiness;
        private GridViewHelper gridViewHelper;
        private UserFeedBack feedBack;
        public ViewProductsForm()
        {
            InitializeComponent();
            productBusiness = new();
            gridViewHelper = new();
            feedBack = new();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            var products = productBusiness.GetProducts();
            productGridView.DataSource = products;
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewHelper.GetColumn(e, productGridView).Equals(ActionEnum.Delete.ToString()))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int categoryId = Convert.ToInt32(gridViewHelper.GetCellValue(e, productGridView, "ProductID"));
                    bool success = productBusiness.RemoveProduct(categoryId);
                    feedBack.ShowFeedbackAlert(success, "Product", "deleted");
                    productGridView.Refresh();
                }
            }
        }
    }
}

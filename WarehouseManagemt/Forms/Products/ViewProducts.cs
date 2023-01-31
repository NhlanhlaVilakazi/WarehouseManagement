using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

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
            productGridView.DataSource = LoadProductList();
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewHelper.GetColumn(e, productGridView).Equals(ActionEnum.Delete.ToString()))
                DeleteteProduct(e);
            else if (GridViewHelper.GetColumn(e, productGridView).Equals(ActionEnum.Update.ToString()))
                UpdateProduct(e);
        }

        private List<ProductViewModel> LoadProductList()
        {
            return productBusiness.GetProducts();
        }

        private void DeleteteProduct(DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(GridViewHelper.GetCellValue(e, productGridView, "ProductID"));
                bool success = productBusiness.RemoveProduct(productId);
                var results = UserFeedBack.ShowFeedbackAlert(success, "Product", "deleted");
                if (results == DialogResult.OK)
                    productGridView.DataSource = LoadProductList();
            }
        }

        private void UpdateProduct(DataGridViewCellEventArgs e)
        {
            int productId = Convert.ToInt32(GridViewHelper.GetCellValue(e, productGridView, "ProductID"));
            new UpdateProduct(productId).Show();
        }
    }
}

using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Categories
{
    public partial class ViewCategoryForm : Form
    {
        private CategoryBusiness categoryBusiness;
        private UserFeedBack feedBack;
        private GridViewHelper gridViewHelper;
        public ViewCategoryForm()
        {
            InitializeComponent();
            categoryBusiness = new();
            gridViewHelper = new();
            feedBack = new();
        }

        private void ViewCategoryForm_Load(object sender, EventArgs e)
        {
            var categories = categoryBusiness.GetCategories();
            categoryGridView.DataSource = categories;
        }

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewHelper.GetColumn(e, categoryGridView).Equals(ActionEnum.Delete.ToString()))
            {
                string? category = gridViewHelper.GetCellValue(e, categoryGridView, "CategoryName").ToString();
                DialogResult dialogResult = MessageBox.Show($"This action will delete all the products that are in the {category} " +
                $"category. Are you sure you want to delete Category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes) 
                {
                    int categoryId = Convert.ToInt32(gridViewHelper.GetCellValue(e, categoryGridView, "CategoryID"));
                    bool success = categoryBusiness.RemoveCategory(categoryId);
                    feedBack.ShowFeedbackAlert(success, "Category", "deleted");
                    categoryGridView.Refresh();
                }  
            }
        }

        private void ViewCategoryForm_Activated(object sender, EventArgs e)
        {
            var categories = categoryBusiness.GetCategories();
            categoryGridView.DataSource = categories;
        }
    }
}

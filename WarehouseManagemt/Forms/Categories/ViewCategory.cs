using WarehouseManagement.ViewModels;
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
            categoryGridView.DataSource = LoadCategoryList();
        }

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewHelper.GetColumn(e, categoryGridView).Equals(ActionEnum.Delete.ToString()))
                DeleteCategory(e);
            else if (GridViewHelper.GetColumn(e, categoryGridView).Equals(ActionEnum.Update.ToString()))
                UpdateCategory(e);
        }

        private void ViewCategoryForm_Activated(object sender, EventArgs e)
        {
            var categories = categoryBusiness.GetCategories();
            categoryGridView.DataSource = categories;
        }

        private void DeleteCategory(DataGridViewCellEventArgs e)
        {
            int categoryId = Convert.ToInt32(GridViewHelper.GetCellValue(e, categoryGridView, "CategoryID"));
            bool success = categoryBusiness.RemoveCategory(categoryId);
            var results = UserFeedBack.ShowFeedbackAlert(success, "Category", "deleted");
            if (results == DialogResult.OK)
                categoryGridView.DataSource = LoadCategoryList();
        }

        private void UpdateCategory(DataGridViewCellEventArgs e)
        {
            int categoryId = Convert.ToInt32(GridViewHelper.GetCellValue(e, categoryGridView, "CategoryID"));
            new UpdateCategory(categoryId).Show();
        }

        private List<CategoryViewModel> LoadCategoryList()
        {
            return categoryBusiness.GetCategories();
        }
    }
}

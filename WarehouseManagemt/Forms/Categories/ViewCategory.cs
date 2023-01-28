using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Categories
{
    public partial class ViewCategoryForm : Form
    {
        private CategoryBusiness categoryBusiness;
        private PrimaryKeyFields keyFields;
        public ViewCategoryForm()
        {
            InitializeComponent();
            categoryBusiness = new();
            keyFields = new();
        }

        private void ViewCategoryForm_Load(object sender, EventArgs e)
        {
            var categories = categoryBusiness.GetCategories();
            categoryGridView.DataSource = categories;
            keyFields.HideFields(categoryGridView, 1);
        }
    }
}

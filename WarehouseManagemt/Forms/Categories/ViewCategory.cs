using WarehouseManagent.Business;

namespace WarehouseManagent.Forms.Categories
{
    public partial class ViewCategoryForm : Form
    {
        private CategoryBusiness categoryBusiness;
        public ViewCategoryForm()
        {
            InitializeComponent();
            categoryBusiness = new();
        }

        private void ViewCategoryForm_Load(object sender, EventArgs e)
        {
            var categories = categoryBusiness.GetCategories();
            categoryGridView.DataSource = categories;
            categoryGridView.Columns[0].Visible = false;
        }
    }
}

using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Categories
{
    public partial class AddCategoryForm : Form
    {
        private PopulateDopdowns dropdown;
        public AddCategoryForm()
        {
            InitializeComponent();
            dropdown = new();
            dropdown.PopulateCategoryDropDown(categoryComboBx);
        }
    }
}

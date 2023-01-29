using WarehouseManagement.ViewModels;
using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Categories
{
    public partial class AddCategoryForm : Form
    {
        private DropdownHelper dropdown;
        private ImageHelper imageHelper;
        private CategoryBusiness categoryBusiness;
        private UserFeedBack feedBack;
        private Bitmap? bitMap;


        public AddCategoryForm()
        {
            InitializeComponent();
            dropdown = new();
            feedBack = new();
            imageHelper = new();
            categoryBusiness = new();
            dropdown.PopulateCategoryDropDown(categoryComboBx);
        }

        private void imageBrowseBtn_Click(object sender, EventArgs e)
        {
            bitMap = imageHelper.LoadSelectedImage(categoryPictureBx);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = categoryBusiness.AddNewCategory(GetCategoryModel());
            feedBack.ShowFeedbackAlert(success, "Category", "added");
        }

        public bool ValidateInput()
        {
            return false;
        }

        public CategoryViewModel GetCategoryModel()
        {
            return new CategoryViewModel
            {
                CategoryName = categoryComboBx.Text,
                Description = descriptionRichTxt.Text,
                Picture = new ImageHelper().ImageToByte(bitMap)
            };
        }
    }
}

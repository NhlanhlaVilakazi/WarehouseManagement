using WarehouseManagement.ViewModels;
using WarehouseManagent.Business;
using WarehouseManagent.Business.TestBusinessClasses;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;
using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Forms.Categories
{
    public partial class AddCategoryForm : Form
    {
        private ImageHelper imageHelper;
        private CategoryBusiness categoryBusiness;
        private UserFeedBack feedBack;
        private Bitmap? bitMap;

        public event EventHandler AddBtn;

        public AddCategoryForm()
        {
            InitializeComponent();
            feedBack = new();
            imageHelper = new();
            categoryBusiness = new();
        }

        private void imageBrowseBtn_Click(object sender, EventArgs e)
        {
            bitMap = imageHelper.LoadSelectedImage(categoryPictureBx);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        { 
            if (!ValidateInput())
            {
                bool success = categoryBusiness.AddNewCategory(GetCategoryModel());
                feedBack.ShowFeedbackAlert(success, "Category", "added");
            }
        }

        public bool ValidateInput()
        {
            bool hasError = false;
            if (string.IsNullOrEmpty(categoryNameTxt.Text))
            {
                categoryNameErrorMsg.Visible = true;
                hasError = true;
            }
            else
                categoryNameErrorMsg.Visible = false;

            if(string.IsNullOrEmpty(descriptionRichTxt.Text))
            {
                descriptionErrorMsg.Visible = true;
                hasError = true;
            }
            else
                descriptionErrorMsg.Visible = false;
            
            if(categoryPictureBx.Image is null)
            {
                pictureErrorMsg.Visible = true;
                hasError = true;
            }
            else
                pictureErrorMsg.Visible = false;

            return hasError;
        }

        public CategoryViewModel GetCategoryModel()
        {
            return new CategoryViewModel
            {
                CategoryName = categoryNameTxt.Text,
                Description = descriptionRichTxt.Text,
                Picture = new ImageHelper().ImageToByte(bitMap)
            };
        }
    }
}

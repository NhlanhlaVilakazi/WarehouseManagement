using WarehouseManagement.ViewModels;
using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

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
            if (ValidInput())
            {
                bool success = categoryBusiness.AddNewCategory(GetCategoryModel());
                feedBack.ShowFeedbackAlert(success, "Category", "added");
            }
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

        #region Validations

        #region Custom
        public bool ValidInput()
        {
            List<bool> validations = new()
            {
                ValidationsHelper.IsValueProvided(categoryNameTxt.Text, categoryNameErrorMsg),
                ValidationsHelper.IsValueProvided(descriptionRichTxt.Text, descriptionErrorMsg),
                ValidationsHelper.IsImageSelected(categoryPictureBx, pictureErrorMsg)
            };
            return validations.All(x => x == true);
        }
        #endregion

        #region ValueChanged
        private void categoryNameTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(categoryNameTxt.Text, categoryNameErrorMsg);
        }

        private void descriptionRichTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(descriptionRichTxt.Text, descriptionErrorMsg);
        }

        private void categoryPictureBx_BackColorChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsImageSelected(categoryPictureBx, pictureErrorMsg);
        }
        #endregion

        #endregion
    }
}

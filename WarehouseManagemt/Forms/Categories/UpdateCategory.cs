using WarehouseManagement.ViewModels;
using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Categories
{
    public partial class UpdateCategory : Form
    {
        private int categoryId;
        private Bitmap? bitMap;
        private UserFeedBack feedBack;
        private ImageHelper imageHelper;
        private DropdownHelper dropdown;
        private CategoryBusiness categoryBusiness;
        public UpdateCategory(int categortID)
        {
            InitializeComponent();
            categoryId = categortID;
            categoryBusiness = new();
            imageHelper= new();
            dropdown = new();
            feedBack = new();

            dropdown.PopulateCategoryDropDown(categoryComboBx);
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            var category = categoryBusiness.GetById(categoryId);
            
            categoryComboBx.SelectedItem  = category.CategoryName;
            descriptionRichTxt.Text = category.Description;
            categoryPictureBx.Image =  new ImageHelper().BytesToImage(category.Picture);
        }

        private void updateImageBtn_Click(object sender, EventArgs e)
        {
            bitMap = imageHelper.LoadSelectedImage(categoryPictureBx);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = categoryBusiness.UpdateCategory(GetCategoryModel());
            var results = UserFeedBack.ShowFeedbackAlert(success, "Category", "updated");
            if (results == DialogResult.OK)
                this.Close();
        }

        public bool ValidateInput()
        {
            return false;
        }

        public CategoryViewModel GetCategoryModel()
        {
            return new CategoryViewModel
            { 
                CategoryID = categoryId,
                CategoryName = categoryComboBx.Text,
                Description = descriptionRichTxt.Text,
                Picture = new ImageHelper().ImageToByte(categoryPictureBx.Image)
            };
        }
    }
}

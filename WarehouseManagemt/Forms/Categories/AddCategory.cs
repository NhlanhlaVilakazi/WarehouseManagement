using WarehouseManagement.ViewModels;
using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Categories
{
    public partial class AddCategoryForm : Form
    {
        private Dropdowns dropdown;
        private CategoryBusiness categoryBusiness;
        private Bitmap imageBit;
        public AddCategoryForm()
        {
            InitializeComponent();
            dropdown = new();
            categoryBusiness = new();
            dropdown.PopulateCategoryDropDown(categoryComboBx);
        }

        private void imageBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new();
            if(imageDialog.ShowDialog() == DialogResult.OK)
            {
                imageBit = new Bitmap(imageDialog.FileName);
                categoryPictureBx.Image= imageBit;
                categoryPictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = categoryBusiness.AddNewCategory(GetCategoryModel());
            if (success) MessageBox.Show("Category successfully added!");
            else MessageBox.Show("An error occured while processing the rquest, please try again later..");
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
                Picture = new PictureConvertor().ImageToByte(imageBit)
            };
        }
    }
}

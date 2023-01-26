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

        private void imageBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new();
            if(imageDialog.ShowDialog() == DialogResult.OK)
            {
                var imageBit = new Bitmap(imageDialog.FileName);
                categoryPictureBx.Image= imageBit;
                categoryPictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

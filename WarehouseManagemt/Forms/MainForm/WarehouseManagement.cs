using WarehouseManagemt.Forms.Categories;
using WarehouseManagemt.Forms.Products;
using WarehouseManagemt.Forms.Supplier;

namespace WarehouseManagemt
{
    public partial class WarehouseManagement : Form
    {
        private Form? activeForm;
        public WarehouseManagement()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        public void CustomizeDesign()
        {
            supplierMenuPanel.Visible = false;
            productMenuPanel.Visible = false;
            categoryMenuPanel.Visible = false;
        }

        public void OpenChildForm(Form childForm)
        {
            if(activeForm is not null) 
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            activeFormTitle.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Manage SubMenu
        public void HideSubMenu()
        {
            if(supplierMenuPanel.Visible)
             supplierMenuPanel.Visible = false;

            if(productMenuPanel.Visible)
                productMenuPanel.Visible = false;

            if(categoryMenuPanel.Visible)
                categoryMenuPanel.Visible = false;
        }

        public void ShowSubMenu(Panel subMenuName)
        {
            if(!subMenuName.Visible)
            {
                HideSubMenu();
                subMenuName.Visible = true;
            }
            else
                subMenuName.Visible = false;
        }
        #endregion

        #region Manage Supplier
        private void manageSupplierBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(supplierMenuPanel);
        }

        private void viewSupplierBtn_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new ViewSuppliersForm());
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new AddSupplierForm());
        }
        #endregion

        #region Manage Product
        private void manageProductBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(productMenuPanel);
        }

        private void viewProductBtn_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new ViewProductsForm());
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new AddProductForm());
        }
        #endregion

        #region Manage Category
        private void manageCategoryBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(categoryMenuPanel);
        }

        private void viewCategoryBtn_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new ViewCategoryForm());
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new AddCategoryForm());
        }
        #endregion
    }
}
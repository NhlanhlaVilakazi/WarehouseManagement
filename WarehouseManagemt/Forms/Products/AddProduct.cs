using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Products
{
    public partial class AddProductForm : Form
    {
        private ProductBusiness productBusiness;
        private Dropdowns dropdowns;
        public AddProductForm()
        {
            InitializeComponent();
            productBusiness = new();
            dropdowns = new();

            dropdowns.PopulateSupplierDropDown(supplierComboBx);
            dropdowns.PopulateCategoryDropDown(categoryComboBx);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = productBusiness.AddNewProduct(GetProductModel());
            if (success) MessageBox.Show("Product successfully added!");
            else MessageBox.Show("An error occured while processing the rquest, please try again later..");
        }

        public bool ValidateInput()
        {
            return false;
        }

        public ProductViewModel GetProductModel()
        {
            return new ProductViewModel
            {
               CategoryID = Convert.ToInt32(categoryComboBx.SelectedValue),
               SupplierID = Convert.ToInt32(supplierComboBx.SelectedValue),
               ProductName = productNameTxt.Text,
               QuantityPerUnit = quantityUnitTxt.Text,
               ReorderLevel = Convert.ToInt16(reorderLevelTxt.Text),
               Discontinued = discontinuedTxt.Text.Equals("Yes") ? true : false,
               UnitPrice = Convert.ToDecimal(unitPriceTxt.Text),
               UnitsInStock = Convert.ToInt16(unitStockTxt.Text),
               UnitsOnOrder = Convert.ToInt16(unitOrderedTxt.Text)
            };
        }

    }
}

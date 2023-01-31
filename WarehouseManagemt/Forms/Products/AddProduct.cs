using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Products
{
    public partial class AddProductForm : Form
    {
        private ProductBusiness productBusiness;
        private DropdownHelper dropdowns;
        private UserFeedBack feedBack;
        public AddProductForm()
        {
            InitializeComponent();
            productBusiness = new();
            dropdowns = new();
            feedBack = new();

            dropdowns.PopulateSupplierDropDown(supplierComboBx);
            dropdowns.PopulateCategoryDropDown(categoryComboBx);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                bool success = productBusiness.AddNewProduct(GetProductModel());
                UserFeedBack.ShowFeedbackAlert(success, "Product", "added");
            }
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

        #region Validations

            #region Custom 
            public bool ValidInput()
            {
                List<bool> validations = new()
                {
                    ValidationsHelper.IsValueProvided(productNameTxt.Text, productNameErrorMsg),
                    ValidationsHelper.IsValueProvided(quantityUnitTxt.Text, quantityPerUnitErrorMsg),
                    ValidationsHelper.IsValueProvided(reorderLevelTxt.Text, reorderLevelErrorMsg),
                    ValidationsHelper.IsValueProvided(unitPriceTxt.Text, unitPriceErrorMsg),
                    ValidationsHelper.IsValueProvided(unitStockTxt.Text, unitsInStockErrorMsg),
                    ValidationsHelper.IsValueProvided(unitOrderedTxt.Text, unitsOnOrderErroeMsg),
                    ValidationsHelper.IsValueProvided(discontinuedTxt.Text, discountinuedErroemsg)
                };
                return validations.All(x => x == true);
            }
            #endregion

            #region Keybord
            private void unitStockTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
            ValidationsHelper.BlockStringInput(e);
            }

            private void unitOrderedTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
            ValidationsHelper.BlockStringInput(e);
            }

            private void reorderLevelTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
            ValidationsHelper.BlockStringInput(e);
            }
            private void unitOrderedTxt_KeyDown(object sender, KeyEventArgs e)
            {
            ValidationsHelper.HandleIntegerInputs(unitOrderedTxt, unitsOnOrderErroeMsg);
            }

            private void unitStockTxt_KeyUp(object sender, KeyEventArgs e)
            {
            ValidationsHelper.HandleIntegerInputs(unitStockTxt, unitsInStockErrorMsg);
            }

            private void unitOrderedTxt_KeyUp(object sender, KeyEventArgs e)
            {
            ValidationsHelper.HandleIntegerInputs(unitOrderedTxt, unitsOnOrderErroeMsg);
            }

            private void reorderLevelTxt_KeyUp(object sender, KeyEventArgs e)
            {
            ValidationsHelper.HandleIntegerInputs(reorderLevelTxt, reorderLevelErrorMsg);
            }

            private void unitPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
            ValidationsHelper.BlockStringInput(e);
            }
            private void unitPriceTxt_KeyUp(object sender, KeyEventArgs e)
            {
            ValidationsHelper.HandleIntegerInputs(unitPriceTxt, unitPriceErrorMsg);
            }
        #endregion

            #region ValueChanges
        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(productNameTxt.Text, productNameErrorMsg);
        }

        private void quantityUnitTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(quantityUnitTxt.Text, quantityPerUnitErrorMsg);
        }

        private void unitPriceTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(unitPriceTxt.Text, unitPriceErrorMsg);
        }

        private void unitStockTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(unitStockTxt.Text, unitsInStockErrorMsg);
        }

        private void unitOrderedTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(unitOrderedTxt.Text, unitsOnOrderErroeMsg);
        }

        private void reorderLevelTxt_TextChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(reorderLevelTxt.Text, reorderLevelErrorMsg);
        }

        private void discontinuedTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidationsHelper.IsValueProvided(discontinuedTxt.Text, discountinuedErroemsg);
        }
        #endregion

        #endregion
        
    }
}

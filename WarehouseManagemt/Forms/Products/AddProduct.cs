using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Products
{
    public partial class AddProductForm : Form
    {
        private ProductBusiness productBusiness;
        private DropdownHelper dropdowns;
        private ValidationsHelper validationsHelper;
        private UserFeedBack feedBack;
        public AddProductForm()
        {
            InitializeComponent();
            productBusiness = new();
            validationsHelper = new();
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
                feedBack.ShowFeedbackAlert(success, "Product", "added");
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
                    validationsHelper.IsTextboxNotNull(productNameTxt, productNameErrorMsg),
                    validationsHelper.IsTextboxNotNull(quantityUnitTxt, quantityPerUnitErrorMsg),
                    validationsHelper.IsTextboxNotNull(reorderLevelTxt, reorderLevelErrorMsg),
                    validationsHelper.IsTextboxNotNull(unitPriceTxt, unitPriceErrorMsg),
                    validationsHelper.IsTextboxNotNull(unitStockTxt, unitsInStockErrorMsg),
                    validationsHelper.IsTextboxNotNull(unitOrderedTxt, unitsOnOrderErroeMsg),
                    validationsHelper.IsDropdownValueSelected(discontinuedTxt, discountinuedErroemsg)
                };
                return validations.All(x => x == true);
            }
            #endregion

            #region Keybord
            private void unitStockTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                validationsHelper.BlockStringInput(e);
            }

            private void unitOrderedTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                validationsHelper.BlockStringInput(e);
            }

            private void reorderLevelTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                validationsHelper.BlockStringInput(e);
            }
            private void unitOrderedTxt_KeyDown(object sender, KeyEventArgs e)
            {
                validationsHelper.HandleIntegerInputs(unitOrderedTxt, unitsOnOrderErroeMsg);
            }

            private void unitStockTxt_KeyUp(object sender, KeyEventArgs e)
            {
                validationsHelper.HandleIntegerInputs(unitStockTxt, unitsInStockErrorMsg);
            }

            private void unitOrderedTxt_KeyUp(object sender, KeyEventArgs e)
            {
                validationsHelper.HandleIntegerInputs(unitOrderedTxt, unitsOnOrderErroeMsg);
            }

            private void reorderLevelTxt_KeyUp(object sender, KeyEventArgs e)
            {
                validationsHelper.HandleIntegerInputs(reorderLevelTxt, reorderLevelErrorMsg);
            }

            private void unitPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                validationsHelper.BlockStringInput(e);
            }
            private void unitPriceTxt_KeyUp(object sender, KeyEventArgs e)
            {
                validationsHelper.HandleIntegerInputs(unitPriceTxt, unitPriceErrorMsg);
            }
        #endregion

            #region ValueChanges
        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {
            validationsHelper.IsTextboxNotNull(productNameTxt, productNameErrorMsg);
        }

        private void quantityUnitTxt_TextChanged(object sender, EventArgs e)
        {
            validationsHelper.IsTextboxNotNull(quantityUnitTxt, quantityPerUnitErrorMsg);
        }

        private void unitPriceTxt_TextChanged(object sender, EventArgs e)
        {
            validationsHelper.IsTextboxNotNull(unitPriceTxt, unitPriceErrorMsg);
        }

        private void unitStockTxt_TextChanged(object sender, EventArgs e)
        {
            validationsHelper.IsTextboxNotNull(unitStockTxt, unitsInStockErrorMsg);
        }

        private void unitOrderedTxt_TextChanged(object sender, EventArgs e)
        {
            validationsHelper.IsTextboxNotNull(unitOrderedTxt, unitsOnOrderErroeMsg);
        }

        private void reorderLevelTxt_TextChanged(object sender, EventArgs e)
        {
            validationsHelper.IsTextboxNotNull(reorderLevelTxt, reorderLevelErrorMsg);
        }

        private void discontinuedTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            validationsHelper.IsDropdownValueSelected(discontinuedTxt, discountinuedErroemsg);
        }
        #endregion

        #endregion
        
    }
}

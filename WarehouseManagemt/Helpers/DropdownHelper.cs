using WarehouseManagent.Business;

namespace WarehouseManagent.Helpers
{
    public static class DropdownHelper
    {
        public static void PopulateSupplierDropDown(ComboBox comboBox)
        {  
            var suppliers = new SupplierBusiness().GetSuppiers();
            comboBox.DataSource = suppliers;
            comboBox.DisplayMember = "CompanyName";
            comboBox.ValueMember = "SupplierID";
        }

        public static void PopulateCategoryDropDown(ComboBox comboBox)
        {
            var categories = new CategoryBusiness().GetCategories();
            comboBox.DataSource = categories;
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryID";
        }
    }
}

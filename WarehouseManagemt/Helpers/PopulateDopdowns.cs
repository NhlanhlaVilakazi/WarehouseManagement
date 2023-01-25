using WarehouseManagent.Business;
using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Helpers
{
    public class PopulateDopdowns
    {
        public void PopulateSupplier(ComboBox comboBox)
        {  
            var suppliers = new SupplierBusiness().GetSuppiers();
            comboBox.DataSource = suppliers;
            comboBox.DisplayMember = "CompanyName";
            comboBox.ValueMember = "SupplierID";
        }

        public void PopulateCategoryDropDown(ComboBox comboBox)
        {
            var categories = new CategoryBusiness().GetCategories();
            comboBox.DataSource = categories;
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryID";
        }
    }
}

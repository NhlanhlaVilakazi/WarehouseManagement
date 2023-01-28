using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Supplier
{
    public partial class AddSupplierForm : Form
    {
        private SupplierBusiness supplierBusiness;
        private UserFeedBack feedBack;
        public AddSupplierForm()
        {
            InitializeComponent();
            feedBack = new();
            supplierBusiness = new();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = supplierBusiness.AddNewSupplier(GetSupplierModel());
            feedBack.ShowFeedbackAlert(success, "Supplier", "added");
        }


        public bool ValidateInput()
        {
            return false;
        }

        public SupplierViewModel GetSupplierModel()
        {
            return new SupplierViewModel
            {
                CompanyName = companyNameTxt.Text,
                ContactName = contactNameTxt.Text,
                ContactTitle = contactTitleTxt.Text,
                PostalCode = postalCodeTxt.Text,
                Address = countryTxt.Text,
                Country = countryTxt.Text,
                HomePage = homePageTxt.Text,
                Region = regionTxt.Text,
                Phone = phoneTxt.Text,
                City = cityTxt.Text,
                Fax = faxTxt.Text
            };
        }
    }
}

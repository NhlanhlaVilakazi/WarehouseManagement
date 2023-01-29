using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Suppliers
{
    public partial class UpdateSupplier : Form
    {
        private int supplierId;
        private SupplierBusiness supplierBusiness;
        private UserFeedBack feedBack;
        public UpdateSupplier(int supplierID)
        {
            InitializeComponent();
            supplierBusiness = new();
            supplierId = supplierID;
            feedBack = new();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            var supplier = supplierBusiness.GetSupplierById(supplierId);
            companyNameTxt.Text = supplier.CompanyName;
            contactNameTxt.Text = supplier.ContactName;
            contactTitleTxt.Text = supplier.ContactTitle;
            addressRichTxt.Text = supplier.Address;
            cityTxt.Text = supplier.City;
            regionTxt.Text = supplier.Region;
            phoneTxt.Text = supplier.Phone;
            postalCodeTxt.Text = supplier.PostalCode;
            countryTxt.Text = supplier.Country;
            faxTxt.Text = supplier.Fax;
            homePageTxt.Text = supplier.HomePage;
        }

        private void supplierUpdateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = supplierBusiness.UpdateSupplier(GetSupplierModel());
            var results = feedBack.ShowFeedbackAlert(success, "Supplier", "updated");
            if (results == DialogResult.OK)
                this.Close();
        }

        public bool ValidateInput()
        {
            return false;
        }

        public SupplierViewModel GetSupplierModel()
        {
            return new SupplierViewModel
            {
                SupplierID = supplierId,
                CompanyName = companyNameTxt.Text,
                ContactName = contactNameTxt.Text,
                ContactTitle = contactTitleTxt.Text,
                PostalCode = postalCodeTxt.Text,
                Address = addressRichTxt.Text,
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

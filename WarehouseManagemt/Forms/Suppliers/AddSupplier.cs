using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Supplier
{
    public partial class AddSupplierForm : Form
    {
        private SupplierBusiness supplierBusiness;
        public AddSupplierForm()
        {
            InitializeComponent();
            supplierBusiness = new();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                bool success = supplierBusiness.AddNewSupplier(GetSupplierModel());
                UserFeedBack.ShowFeedbackAlert(success, "Supplier", "added");
            }
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

        #region Validations

            #region Custom
            private bool ValidInput()
            {
                List<bool> validations = new()
                {
                    ValidationsHelper.IsValueProvided(companyNameTxt.Text, companyNameErrorMsg),
                    ValidationsHelper.IsValueProvided(contactNameTxt.Text, contactNameErrorMsg),
                    ValidationsHelper.IsValueProvided(contactTitleTxt.Text, contactTitleErrorMsg),
                    ValidationsHelper.IsValueProvided(postalCodeTxt.Text, postalCodeErrorMsg),
                    ValidationsHelper.IsValueProvided(countryTxt.Text, countryErrorMsg),
                    ValidationsHelper.IsValueProvided(addressRichTxt.Text, addressErrorMsg),
                    ValidationsHelper.IsValueProvided(phoneTxt.Text, phoneErrorMsg),
                    ValidationsHelper.IsValueProvided(cityTxt.Text, cityErrorMsg)
                };
                return validations.All(x => x == true);
            }
           #endregion

            #region ValueChanged
            private void contactTitleTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(contactTitleTxt.Text, contactTitleErrorMsg);
            }

            private void companyNameTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(companyNameTxt.Text, companyNameErrorMsg);
            }

            private void contactNameTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(contactNameTxt.Text, contactNameErrorMsg);
            }

            private void addressRichTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(addressRichTxt.Text, addressErrorMsg);
            }

            private void cityTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(cityTxt.Text, cityErrorMsg);
            }

            private void postalCodeTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(postalCodeTxt.Text, postalCodeErrorMsg);
            }

            private void countryTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(countryTxt.Text, countryErrorMsg);
            }

            private void phoneTxt_TextChanged(object sender, EventArgs e)
            {
                ValidationsHelper.IsValueProvided(phoneTxt.Text, phoneErrorMsg);
            }
            #endregion

        #endregion
    }
}

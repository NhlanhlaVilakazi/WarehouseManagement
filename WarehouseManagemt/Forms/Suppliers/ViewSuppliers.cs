using System.Data;
using WarehouseManagent.Business;
using WarehouseManagent.Forms.Categories;
using WarehouseManagent.Forms.Suppliers;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Supplier
{
    public partial class ViewSuppliersForm : Form
    {
        private SupplierBusiness supplierBusiness;
        private GridViewHelper gridViewHelper;
        private UserFeedBack feedBack;

        public ViewSuppliersForm()
        {
            InitializeComponent();
            supplierBusiness = new();
            gridViewHelper = new();
            feedBack = new();
        }

        private void ViewSuppliersForm_Load(object sender, EventArgs e)
        {
            supplierGridView.DataSource = LoadSupplierList();
        }

        private void supplierGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewHelper.GetColumn(e, supplierGridView).Equals(ActionEnum.Delete.ToString()))
                DeleteSupplier(e);
            else if (gridViewHelper.GetColumn(e, supplierGridView).Equals(ActionEnum.Update.ToString()))
                UpdateSupplier(e);
        }

        private List<SupplierViewModel> LoadSupplierList()
        {
            return supplierBusiness.GetSuppiers();
        }

        private void DeleteSupplier(DataGridViewCellEventArgs e)
        {
            string? supplier = gridViewHelper.GetCellValue(e, supplierGridView, "CompanyName").ToString();
            DialogResult dialogResult = MessageBox.Show($"This action will delete all products that are supplied by {supplier} ." +
            $" Are you sure you want to delete Supplier?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int supplierId = Convert.ToInt32(gridViewHelper.GetCellValue(e, supplierGridView, "SupplierID"));
                bool success = supplierBusiness.RemoveSupplier(supplierId);
                var results = feedBack.ShowFeedbackAlert(success, "Supplier", "deleted");
                if (results == DialogResult.OK)
                    supplierGridView.DataSource = LoadSupplierList();
            }
        }

        private void UpdateSupplier(DataGridViewCellEventArgs e)
        {
            int supplierId = Convert.ToInt32(gridViewHelper.GetCellValue(e, supplierGridView, "SupplierID"));
            new UpdateSupplier(supplierId).Show();
        }
    }
}

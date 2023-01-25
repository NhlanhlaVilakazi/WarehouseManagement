using WarehouseManagent.Business;
using WarehouseManagent.Helpers;

namespace WarehouseManagent.Forms.Supplier
{
    public partial class ViewSuppliersForm : Form
    {
        private SupplierBusiness supplierBusiness;
        private HidePrimaryKeyFields keyFields;


        public ViewSuppliersForm()
        {
            InitializeComponent();
            supplierBusiness = new();
            keyFields = new();
        }

        private void ViewSuppliersForm_Load(object sender, EventArgs e)
        {
            var suppliers = supplierBusiness.GetSuppiers();
            supplierGridView.DataSource = suppliers;
            keyFields.HideFields(supplierGridView, 1);
        }
    }
}

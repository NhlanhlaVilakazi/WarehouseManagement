using WarehouseManagent.Business;

namespace WarehouseManagent.Forms.Supplier
{
    public partial class ViewSuppliersForm : Form
    {
        private SupplierBusiness supplierBusiness;


        public ViewSuppliersForm()
        {
            InitializeComponent();
            supplierBusiness = new();
        }

        private void ViewSuppliersForm_Load(object sender, EventArgs e)
        {
            var suppliers = supplierBusiness.GetSuppiers();
            supplierGridView.DataSource = suppliers;
        }
    }
}

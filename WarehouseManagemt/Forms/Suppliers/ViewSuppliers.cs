using WarehouseManagent.Business;

namespace WarehouseManagent.Forms.Supplier
{
    public partial class ViewSuppliersForm : Form
    {
        private readonly SupplierBusiness supplierBusiness;
        
        public ViewSuppliersForm()
        {
            InitializeComponent();
            supplierBusiness = new SupplierBusiness();
        }

        private void ViewSuppliersForm_Load(object sender, EventArgs e)
        {
            var suppliers = supplierBusiness.GetSuppiers();
            supplierGridView.DataSource = suppliers;
            supplierGridView.Columns[0].Visible = false;
        }
    }
}

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
            foreach (var supplier in suppliers) 
            {
                supplierGridView.Rows.Add(supplier.ContactName, supplier.ContactTitle, supplier.ContactName,supplier.Address,
                supplier.City, supplier.Region, supplier.PostalCode, supplier.Country, supplier.Phone, supplier.Fax, supplier.HomePage);
            }
        }
    }
}

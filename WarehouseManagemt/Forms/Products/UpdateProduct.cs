using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using WarehouseManagent.Business;
using WarehouseManagent.Helpers;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Forms.Products
{
    public partial class UpdateProduct : Form
    {
        private int productId;
        private ProductBusiness productBusiness;
        private DropdownHelper dropdowns;
        private UserFeedBack feedBack;
        public UpdateProduct(int productID)
        {
            InitializeComponent();
            productId = productID;
            productBusiness = new();
            dropdowns = new();
            feedBack = new();

            dropdowns.PopulateSupplierDropDown(supplierComboBx);
            dropdowns.PopulateCategoryDropDown(categoryComboBx);
        }

        private void updateproductBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Please input all fields!");
                return;
            }
            bool success = productBusiness.UpdateProduct(GetProductModel());
            var results = feedBack.ShowFeedbackAlert(success, "Product", "updated");
            if (results == DialogResult.OK)
                this.Close();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            var product = productBusiness.GetProduct(productId);
            productNameTxt.Text = product.ProductName;
            quantityUnitTxt.Text = product.QuantityPerUnit.ToString();
            unitPriceTxt.Text = product.UnitPrice.ToString();
            unitOrderedTxt.Text = product.UnitsOnOrder.ToString();
            unitStockTxt.Text = product.UnitsInStock.ToString();
            reorderLevelTxt.Text = product.ReorderLevel.ToString();
            discontinuedTxt.Text = product.Discontinued ? "Yes" : "No";
        }

        public bool ValidateInput()
        {
            return false;
        }

        public ProductViewModel GetProductModel()
        {
            return new ProductViewModel
            {
                ProductID = productId,
                CategoryID = Convert.ToInt32(categoryComboBx.SelectedValue),
                SupplierID = Convert.ToInt32(supplierComboBx.SelectedValue),
                ProductName = productNameTxt.Text,
                QuantityPerUnit = quantityUnitTxt.Text,
                ReorderLevel = Convert.ToInt16(reorderLevelTxt.Text),
                Discontinued = discontinuedTxt.Text.Equals("Yes") ? true : false,
                UnitPrice = Convert.ToDecimal(unitPriceTxt.Text),
                UnitsInStock = Convert.ToInt16(unitStockTxt.Text),
                UnitsOnOrder = Convert.ToInt16(unitOrderedTxt.Text)
            };
        }
    }
}

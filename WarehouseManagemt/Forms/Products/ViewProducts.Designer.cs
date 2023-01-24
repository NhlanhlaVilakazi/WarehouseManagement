namespace WarehouseManagemt.Forms.Products
{
    partial class ViewProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.category,
            this.quantity,
            this.unitPrice,
            this.unitInStock,
            this.unitsOnOrder,
            this.reOrderLevel,
            this.discountinued});
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.Location = new System.Drawing.Point(0, 0);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 25;
            this.productGridView.Size = new System.Drawing.Size(712, 466);
            this.productGridView.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            // 
            // unitInStock
            // 
            this.unitInStock.HeaderText = "Units In Stock";
            this.unitInStock.Name = "unitInStock";
            // 
            // unitsOnOrder
            // 
            this.unitsOnOrder.HeaderText = "Units On Order";
            this.unitsOnOrder.Name = "unitsOnOrder";
            // 
            // reOrderLevel
            // 
            this.reOrderLevel.HeaderText = "Reorder Level";
            this.reOrderLevel.Name = "reOrderLevel";
            // 
            // discountinued
            // 
            this.discountinued.HeaderText = "Discountinued";
            this.discountinued.Name = "discountinued";
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 466);
            this.Controls.Add(this.productGridView);
            this.Name = "ViewProductsForm";
            this.Text = "View Products";
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView productGridView;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn unitInStock;
        private DataGridViewTextBoxColumn unitsOnOrder;
        private DataGridViewTextBoxColumn reOrderLevel;
        private DataGridViewTextBoxColumn discountinued;
    }
}
namespace WarehouseManagemt.Forms.Supplier
{
    partial class ViewSuppliersForm
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
            this.supplierGridView = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGridView
            // 
            this.supplierGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.contactTitle,
            this.contactName,
            this.address,
            this.city,
            this.region,
            this.postalCode,
            this.country,
            this.phone});
            this.supplierGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGridView.Location = new System.Drawing.Point(0, 0);
            this.supplierGridView.Name = "supplierGridView";
            this.supplierGridView.RowTemplate.Height = 25;
            this.supplierGridView.Size = new System.Drawing.Size(712, 466);
            this.supplierGridView.TabIndex = 1;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            // 
            // contactTitle
            // 
            this.contactTitle.HeaderText = "Contact Title";
            this.contactTitle.Name = "contactTitle";
            // 
            // contactName
            // 
            this.contactName.HeaderText = "Contact Name";
            this.contactName.Name = "contactName";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // region
            // 
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            // 
            // postalCode
            // 
            this.postalCode.HeaderText = "Postal Code";
            this.postalCode.Name = "postalCode";
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // ViewSuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 466);
            this.Controls.Add(this.supplierGridView);
            this.Name = "ViewSuppliersForm";
            this.Text = "View Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView supplierGridView;
        private DataGridViewTextBoxColumn companyName;
        private DataGridViewTextBoxColumn contactTitle;
        private DataGridViewTextBoxColumn contactName;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn region;
        private DataGridViewTextBoxColumn postalCode;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn phone;
    }
}
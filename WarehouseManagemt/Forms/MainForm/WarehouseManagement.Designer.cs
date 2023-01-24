namespace WarehouseManagemt
{
    partial class WarehouseManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseManagement));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.categoryMenuPanel = new System.Windows.Forms.Panel();
            this.addCategory = new System.Windows.Forms.Button();
            this.viewCategoryBtn = new System.Windows.Forms.Button();
            this.manageCategoryBtn = new System.Windows.Forms.Button();
            this.productMenuPanel = new System.Windows.Forms.Panel();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.viewProductBtn = new System.Windows.Forms.Button();
            this.manageProductBtn = new System.Windows.Forms.Button();
            this.supplierMenuPanel = new System.Windows.Forms.Panel();
            this.addSupplierBtn = new System.Windows.Forms.Button();
            this.viewSupplierBtn = new System.Windows.Forms.Button();
            this.manageSupplierBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.activeFormTitle = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.categoryMenuPanel.SuspendLayout();
            this.productMenuPanel.SuspendLayout();
            this.supplierMenuPanel.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuPanel.Controls.Add(this.categoryMenuPanel);
            this.menuPanel.Controls.Add(this.manageCategoryBtn);
            this.menuPanel.Controls.Add(this.productMenuPanel);
            this.menuPanel.Controls.Add(this.manageProductBtn);
            this.menuPanel.Controls.Add(this.supplierMenuPanel);
            this.menuPanel.Controls.Add(this.manageSupplierBtn);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 571);
            this.menuPanel.TabIndex = 0;
            // 
            // categoryMenuPanel
            // 
            this.categoryMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.categoryMenuPanel.Controls.Add(this.addCategory);
            this.categoryMenuPanel.Controls.Add(this.viewCategoryBtn);
            this.categoryMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryMenuPanel.Location = new System.Drawing.Point(0, 409);
            this.categoryMenuPanel.Name = "categoryMenuPanel";
            this.categoryMenuPanel.Size = new System.Drawing.Size(200, 104);
            this.categoryMenuPanel.TabIndex = 5;
            // 
            // addCategory
            // 
            this.addCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCategory.FlatAppearance.BorderSize = 0;
            this.addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCategory.Image = global::WarehouseManagemt.Properties.Resources.category_add;
            this.addCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategory.Location = new System.Drawing.Point(0, 40);
            this.addCategory.Name = "addCategory";
            this.addCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addCategory.Size = new System.Drawing.Size(200, 40);
            this.addCategory.TabIndex = 1;
            this.addCategory.Text = "Add Category";
            this.addCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // viewCategoryBtn
            // 
            this.viewCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCategoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewCategoryBtn.FlatAppearance.BorderSize = 0;
            this.viewCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCategoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewCategoryBtn.Image = global::WarehouseManagemt.Properties.Resources.eye;
            this.viewCategoryBtn.Location = new System.Drawing.Point(0, 0);
            this.viewCategoryBtn.Name = "viewCategoryBtn";
            this.viewCategoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.viewCategoryBtn.Size = new System.Drawing.Size(200, 40);
            this.viewCategoryBtn.TabIndex = 0;
            this.viewCategoryBtn.Text = "View Categories";
            this.viewCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewCategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewCategoryBtn.UseVisualStyleBackColor = true;
            this.viewCategoryBtn.Click += new System.EventHandler(this.viewCategoryBtn_Click);
            // 
            // manageCategoryBtn
            // 
            this.manageCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageCategoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageCategoryBtn.FlatAppearance.BorderSize = 0;
            this.manageCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCategoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageCategoryBtn.Image = global::WarehouseManagemt.Properties.Resources.manage_cat;
            this.manageCategoryBtn.Location = new System.Drawing.Point(0, 364);
            this.manageCategoryBtn.Name = "manageCategoryBtn";
            this.manageCategoryBtn.Size = new System.Drawing.Size(200, 45);
            this.manageCategoryBtn.TabIndex = 4;
            this.manageCategoryBtn.Text = " Manage Categories";
            this.manageCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageCategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageCategoryBtn.UseVisualStyleBackColor = true;
            this.manageCategoryBtn.Click += new System.EventHandler(this.manageCategoryBtn_Click);
            // 
            // productMenuPanel
            // 
            this.productMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.productMenuPanel.Controls.Add(this.addProductBtn);
            this.productMenuPanel.Controls.Add(this.viewProductBtn);
            this.productMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productMenuPanel.Location = new System.Drawing.Point(0, 260);
            this.productMenuPanel.Name = "productMenuPanel";
            this.productMenuPanel.Size = new System.Drawing.Size(200, 104);
            this.productMenuPanel.TabIndex = 3;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addProductBtn.Image = global::WarehouseManagemt.Properties.Resources.prod1;
            this.addProductBtn.Location = new System.Drawing.Point(0, 40);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addProductBtn.Size = new System.Drawing.Size(200, 40);
            this.addProductBtn.TabIndex = 1;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // viewProductBtn
            // 
            this.viewProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewProductBtn.FlatAppearance.BorderSize = 0;
            this.viewProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewProductBtn.Image = global::WarehouseManagemt.Properties.Resources.eye;
            this.viewProductBtn.Location = new System.Drawing.Point(0, 0);
            this.viewProductBtn.Name = "viewProductBtn";
            this.viewProductBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.viewProductBtn.Size = new System.Drawing.Size(200, 40);
            this.viewProductBtn.TabIndex = 0;
            this.viewProductBtn.Text = "View Products";
            this.viewProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewProductBtn.UseVisualStyleBackColor = true;
            this.viewProductBtn.Click += new System.EventHandler(this.viewProductBtn_Click);
            // 
            // manageProductBtn
            // 
            this.manageProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageProductBtn.FlatAppearance.BorderSize = 0;
            this.manageProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageProductBtn.Image = global::WarehouseManagemt.Properties.Resources.boxes;
            this.manageProductBtn.Location = new System.Drawing.Point(0, 215);
            this.manageProductBtn.Name = "manageProductBtn";
            this.manageProductBtn.Size = new System.Drawing.Size(200, 45);
            this.manageProductBtn.TabIndex = 2;
            this.manageProductBtn.Text = " Manage Products";
            this.manageProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageProductBtn.UseVisualStyleBackColor = true;
            this.manageProductBtn.Click += new System.EventHandler(this.manageProductBtn_Click);
            // 
            // supplierMenuPanel
            // 
            this.supplierMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.supplierMenuPanel.Controls.Add(this.addSupplierBtn);
            this.supplierMenuPanel.Controls.Add(this.viewSupplierBtn);
            this.supplierMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierMenuPanel.Location = new System.Drawing.Point(0, 111);
            this.supplierMenuPanel.Name = "supplierMenuPanel";
            this.supplierMenuPanel.Size = new System.Drawing.Size(200, 104);
            this.supplierMenuPanel.TabIndex = 1;
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSupplierBtn.FlatAppearance.BorderSize = 0;
            this.addSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addSupplierBtn.Image = global::WarehouseManagemt.Properties.Resources.uuser;
            this.addSupplierBtn.Location = new System.Drawing.Point(0, 40);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addSupplierBtn.Size = new System.Drawing.Size(200, 40);
            this.addSupplierBtn.TabIndex = 1;
            this.addSupplierBtn.Text = "Add Supplier";
            this.addSupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSupplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addSupplierBtn.UseVisualStyleBackColor = true;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // viewSupplierBtn
            // 
            this.viewSupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewSupplierBtn.FlatAppearance.BorderSize = 0;
            this.viewSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewSupplierBtn.Image = global::WarehouseManagemt.Properties.Resources.eye;
            this.viewSupplierBtn.Location = new System.Drawing.Point(0, 0);
            this.viewSupplierBtn.Name = "viewSupplierBtn";
            this.viewSupplierBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.viewSupplierBtn.Size = new System.Drawing.Size(200, 40);
            this.viewSupplierBtn.TabIndex = 0;
            this.viewSupplierBtn.Text = "View Suppliers";
            this.viewSupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSupplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewSupplierBtn.UseVisualStyleBackColor = true;
            this.viewSupplierBtn.Click += new System.EventHandler(this.viewSupplierBtn_Click);
            // 
            // manageSupplierBtn
            // 
            this.manageSupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageSupplierBtn.FlatAppearance.BorderSize = 0;
            this.manageSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageSupplierBtn.Image = global::WarehouseManagemt.Properties.Resources.supp;
            this.manageSupplierBtn.Location = new System.Drawing.Point(0, 66);
            this.manageSupplierBtn.Name = "manageSupplierBtn";
            this.manageSupplierBtn.Size = new System.Drawing.Size(200, 45);
            this.manageSupplierBtn.TabIndex = 1;
            this.manageSupplierBtn.Text = " Manage Suppliers";
            this.manageSupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageSupplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageSupplierBtn.UseVisualStyleBackColor = true;
            this.manageSupplierBtn.Click += new System.EventHandler(this.manageSupplierBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 66);
            this.panel2.TabIndex = 1;
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.topBarPanel.Controls.Add(this.activeFormTitle);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(200, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(728, 66);
            this.topBarPanel.TabIndex = 2;
            // 
            // activeFormTitle
            // 
            this.activeFormTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activeFormTitle.AutoSize = true;
            this.activeFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activeFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.activeFormTitle.Location = new System.Drawing.Point(314, 20);
            this.activeFormTitle.Name = "activeFormTitle";
            this.activeFormTitle.Size = new System.Drawing.Size(83, 32);
            this.activeFormTitle.TabIndex = 0;
            this.activeFormTitle.Text = "label1";
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(200, 66);
            this.childFormPanel.MinimumSize = new System.Drawing.Size(678, 455);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(728, 505);
            this.childFormPanel.TabIndex = 3;
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 571);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(844, 355);
            this.Name = "WarehouseManagement";
            this.Text = "Northwind Warehouse Management System";
            this.menuPanel.ResumeLayout(false);
            this.categoryMenuPanel.ResumeLayout(false);
            this.productMenuPanel.ResumeLayout(false);
            this.supplierMenuPanel.ResumeLayout(false);
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel supplierMenuPanel;
        private Button manageSupplierBtn;
        private Panel panel2;
        private Button addSupplierBtn;
        private Button viewSupplierBtn;
        private Panel categoryMenuPanel;
        private Button addCategory;
        private Button viewCategoryBtn;
        private Button manageCategoryBtn;
        private Panel productMenuPanel;
        private Button addProductBtn;
        private Button viewProductBtn;
        private Button manageProductBtn;
        private Panel topBarPanel;
        private Label activeFormTitle;
        private Panel childFormPanel;
    }
}
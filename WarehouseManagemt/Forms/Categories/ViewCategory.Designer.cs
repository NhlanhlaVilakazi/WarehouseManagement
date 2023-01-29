namespace WarehouseManagent.Forms.Categories
{
    partial class ViewCategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.updateBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AllowUserToDeleteRows = false;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.Description,
            this.Picture,
            this.updateBtn,
            this.deleteBtn});
            this.categoryGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryGridView.Location = new System.Drawing.Point(0, 0);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowTemplate.Height = 100;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(1009, 466);
            this.categoryGridView.TabIndex = 1;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellClick);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // updateBtn
            // 
            this.updateBtn.HeaderText = "Update";
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ReadOnly = true;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.HeaderText = "Delete";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // ViewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.categoryGridView);
            this.Name = "ViewCategoryForm";
            this.Text = "All Categories";
            this.Activated += new System.EventHandler(this.ViewCategoryForm_Activated);
            this.Load += new System.EventHandler(this.ViewCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView categoryGridView;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewImageColumn Picture;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
    }
}
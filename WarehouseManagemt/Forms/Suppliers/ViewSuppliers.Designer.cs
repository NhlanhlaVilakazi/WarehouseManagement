namespace WarehouseManagent.Forms.Supplier
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
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGridView
            // 
            this.supplierGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGridView.Location = new System.Drawing.Point(0, 0);
            this.supplierGridView.Name = "supplierGridView";
            this.supplierGridView.RowTemplate.Height = 25;
            this.supplierGridView.Size = new System.Drawing.Size(1009, 466);
            this.supplierGridView.TabIndex = 1;
            // 
            // ViewSuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.supplierGridView);
            this.Name = "ViewSuppliersForm";
            this.Text = "View Suppliers";
            this.Load += new System.EventHandler(this.ViewSuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView supplierGridView;
    }
}
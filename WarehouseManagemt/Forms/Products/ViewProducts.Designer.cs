namespace WarehouseManagent.Forms.Products
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
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.Location = new System.Drawing.Point(0, 0);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 25;
            this.productGridView.Size = new System.Drawing.Size(1009, 466);
            this.productGridView.TabIndex = 1;
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.productGridView);
            this.Name = "ViewProductsForm";
            this.Text = "All Product(s)";
            this.Load += new System.EventHandler(this.ViewProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView productGridView;
    }
}
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
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGridView
            // 
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryGridView.Location = new System.Drawing.Point(0, 0);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowTemplate.Height = 100;
            this.categoryGridView.Size = new System.Drawing.Size(1009, 466);
            this.categoryGridView.TabIndex = 1;
            // 
            // ViewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.categoryGridView);
            this.Name = "ViewCategoryForm";
            this.Text = "All Categories";
            this.Load += new System.EventHandler(this.ViewCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView categoryGridView;
    }
}
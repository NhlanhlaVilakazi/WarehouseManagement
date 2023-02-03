namespace WarehouseManagent.Forms.Categories
{
    partial class UpdateCategory
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
            this.updateImageBtn = new System.Windows.Forms.Button();
            this.categoryComboBx = new System.Windows.Forms.ComboBox();
            this.descriptionRichTxt = new System.Windows.Forms.RichTextBox();
            this.categoryPictureBx = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pictureErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // updateImageBtn
            // 
            this.updateImageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateImageBtn.Location = new System.Drawing.Point(482, 300);
            this.updateImageBtn.Name = "updateImageBtn";
            this.updateImageBtn.Size = new System.Drawing.Size(201, 23);
            this.updateImageBtn.TabIndex = 99;
            this.updateImageBtn.Text = "Change Image";
            this.updateImageBtn.UseVisualStyleBackColor = true;
            this.updateImageBtn.Click += new System.EventHandler(this.updateImageBtn_Click);
            // 
            // categoryComboBx
            // 
            this.categoryComboBx.FormattingEnabled = true;
            this.categoryComboBx.Location = new System.Drawing.Point(119, 87);
            this.categoryComboBx.Name = "categoryComboBx";
            this.categoryComboBx.Size = new System.Drawing.Size(291, 23);
            this.categoryComboBx.TabIndex = 98;
            // 
            // descriptionRichTxt
            // 
            this.descriptionRichTxt.Location = new System.Drawing.Point(118, 141);
            this.descriptionRichTxt.Name = "descriptionRichTxt";
            this.descriptionRichTxt.Size = new System.Drawing.Size(291, 182);
            this.descriptionRichTxt.TabIndex = 97;
            this.descriptionRichTxt.Text = "";
            // 
            // categoryPictureBx
            // 
            this.categoryPictureBx.Location = new System.Drawing.Point(482, 87);
            this.categoryPictureBx.Name = "categoryPictureBx";
            this.categoryPictureBx.Size = new System.Drawing.Size(201, 185);
            this.categoryPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryPictureBx.TabIndex = 96;
            this.categoryPictureBx.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(118, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 95;
            this.label10.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(118, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 94;
            this.label6.Text = "CategoryName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(482, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Picture";
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Location = new System.Drawing.Point(583, 360);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 23);
            this.updateBtn.TabIndex = 90;
            this.updateBtn.Text = "Save Changes";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pictureErrorMsg
            // 
            this.pictureErrorMsg.AutoSize = true;
            this.pictureErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pictureErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.pictureErrorMsg.Location = new System.Drawing.Point(482, 275);
            this.pictureErrorMsg.Name = "pictureErrorMsg";
            this.pictureErrorMsg.Size = new System.Drawing.Size(173, 15);
            this.pictureErrorMsg.TabIndex = 100;
            this.pictureErrorMsg.Text = "Please select category picture";
            this.pictureErrorMsg.Visible = false;
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureErrorMsg);
            this.Controls.Add(this.updateImageBtn);
            this.Controls.Add(this.categoryComboBx);
            this.Controls.Add(this.descriptionRichTxt);
            this.Controls.Add(this.categoryPictureBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateBtn);
            this.Name = "UpdateCategory";
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateImageBtn;
        private ComboBox categoryComboBx;
        private RichTextBox descriptionRichTxt;
        private PictureBox categoryPictureBx;
        private Label label10;
        private Label label6;
        private Label label5;
        private Button updateBtn;
        private Label pictureErrorMsg;
    }
}
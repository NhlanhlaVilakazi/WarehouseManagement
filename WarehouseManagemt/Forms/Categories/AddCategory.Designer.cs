namespace WarehouseManagent.Forms.Categories
{
    partial class AddCategoryForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryPictureBx = new System.Windows.Forms.PictureBox();
            this.descriptionRichTxt = new System.Windows.Forms.RichTextBox();
            this.imageBrowseBtn = new System.Windows.Forms.Button();
            this.categoryNameErrorMsg = new System.Windows.Forms.Label();
            this.pictureErrorMsg = new System.Windows.Forms.Label();
            this.descriptionErrorMsg = new System.Windows.Forms.Label();
            this.categoryNameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(170, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 85;
            this.label10.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(170, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 82;
            this.label6.Text = "CategoryName";
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(660, 395);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 74;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(534, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "Picture";
            // 
            // categoryPictureBx
            // 
            this.categoryPictureBx.Location = new System.Drawing.Point(534, 122);
            this.categoryPictureBx.Name = "categoryPictureBx";
            this.categoryPictureBx.Size = new System.Drawing.Size(201, 207);
            this.categoryPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryPictureBx.TabIndex = 86;
            this.categoryPictureBx.TabStop = false;
            // 
            // descriptionRichTxt
            // 
            this.descriptionRichTxt.Location = new System.Drawing.Point(171, 190);
            this.descriptionRichTxt.Name = "descriptionRichTxt";
            this.descriptionRichTxt.Size = new System.Drawing.Size(291, 113);
            this.descriptionRichTxt.TabIndex = 87;
            this.descriptionRichTxt.Text = "";
            // 
            // imageBrowseBtn
            // 
            this.imageBrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBrowseBtn.Location = new System.Drawing.Point(170, 329);
            this.imageBrowseBtn.Name = "imageBrowseBtn";
            this.imageBrowseBtn.Size = new System.Drawing.Size(291, 23);
            this.imageBrowseBtn.TabIndex = 89;
            this.imageBrowseBtn.Text = "Select Image";
            this.imageBrowseBtn.UseVisualStyleBackColor = true;
            this.imageBrowseBtn.Click += new System.EventHandler(this.imageBrowseBtn_Click);
            // 
            // categoryNameErrorMsg
            // 
            this.categoryNameErrorMsg.AutoSize = true;
            this.categoryNameErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryNameErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.categoryNameErrorMsg.Location = new System.Drawing.Point(171, 146);
            this.categoryNameErrorMsg.Name = "categoryNameErrorMsg";
            this.categoryNameErrorMsg.Size = new System.Drawing.Size(160, 15);
            this.categoryNameErrorMsg.TabIndex = 90;
            this.categoryNameErrorMsg.Text = "Please input category name";
            this.categoryNameErrorMsg.Visible = false;
            // 
            // pictureErrorMsg
            // 
            this.pictureErrorMsg.AutoSize = true;
            this.pictureErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pictureErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.pictureErrorMsg.Location = new System.Drawing.Point(534, 332);
            this.pictureErrorMsg.Name = "pictureErrorMsg";
            this.pictureErrorMsg.Size = new System.Drawing.Size(173, 15);
            this.pictureErrorMsg.TabIndex = 91;
            this.pictureErrorMsg.Text = "Please select category picture";
            this.pictureErrorMsg.Visible = false;
            // 
            // descriptionErrorMsg
            // 
            this.descriptionErrorMsg.AutoSize = true;
            this.descriptionErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.descriptionErrorMsg.Location = new System.Drawing.Point(170, 306);
            this.descriptionErrorMsg.Name = "descriptionErrorMsg";
            this.descriptionErrorMsg.Size = new System.Drawing.Size(139, 15);
            this.descriptionErrorMsg.TabIndex = 92;
            this.descriptionErrorMsg.Text = "Please input description";
            this.descriptionErrorMsg.Visible = false;
            // 
            // categoryNameTxt
            // 
            this.categoryNameTxt.Location = new System.Drawing.Point(171, 122);
            this.categoryNameTxt.Name = "categoryNameTxt";
            this.categoryNameTxt.Size = new System.Drawing.Size(290, 23);
            this.categoryNameTxt.TabIndex = 93;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.categoryNameTxt);
            this.Controls.Add(this.descriptionErrorMsg);
            this.Controls.Add(this.pictureErrorMsg);
            this.Controls.Add(this.categoryNameErrorMsg);
            this.Controls.Add(this.imageBrowseBtn);
            this.Controls.Add(this.descriptionRichTxt);
            this.Controls.Add(this.categoryPictureBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBtn);
            this.Name = "AddCategoryForm";
            this.Text = "Add Category";
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Label label6;
        private Button saveBtn;
        private Label label5;
        private PictureBox categoryPictureBx;
        private RichTextBox descriptionRichTxt;
        private Button imageBrowseBtn;
        private Label categoryNameErrorMsg;
        private Label pictureErrorMsg;
        private Label descriptionErrorMsg;
        private TextBox categoryNameTxt;
    }
}
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
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryPictureBx = new System.Windows.Forms.PictureBox();
            this.descriptionRichTxt = new System.Windows.Forms.RichTextBox();
            this.categoryComboBx = new System.Windows.Forms.ComboBox();
            this.imageBrowseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(278, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 85;
            this.label10.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(278, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 82;
            this.label6.Text = "CategoryName";
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Location = new System.Drawing.Point(293, 395);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 76;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Location = new System.Drawing.Point(473, 395);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 75;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
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
            this.categoryPictureBx.TabIndex = 86;
            this.categoryPictureBx.TabStop = false;
            // 
            // descriptionRichTxt
            // 
            this.descriptionRichTxt.Location = new System.Drawing.Point(282, 176);
            this.descriptionRichTxt.Name = "descriptionRichTxt";
            this.descriptionRichTxt.Size = new System.Drawing.Size(180, 113);
            this.descriptionRichTxt.TabIndex = 87;
            this.descriptionRichTxt.Text = "";
            // 
            // categoryComboBx
            // 
            this.categoryComboBx.FormattingEnabled = true;
            this.categoryComboBx.Location = new System.Drawing.Point(282, 122);
            this.categoryComboBx.Name = "categoryComboBx";
            this.categoryComboBx.Size = new System.Drawing.Size(180, 23);
            this.categoryComboBx.TabIndex = 88;
            // 
            // imageBrowseBtn
            // 
            this.imageBrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBrowseBtn.Location = new System.Drawing.Point(282, 306);
            this.imageBrowseBtn.Name = "imageBrowseBtn";
            this.imageBrowseBtn.Size = new System.Drawing.Size(180, 23);
            this.imageBrowseBtn.TabIndex = 89;
            this.imageBrowseBtn.Text = "Select Image";
            this.imageBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.imageBrowseBtn);
            this.Controls.Add(this.categoryComboBx);
            this.Controls.Add(this.descriptionRichTxt);
            this.Controls.Add(this.categoryPictureBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
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
        private Button backBtn;
        private Button clearBtn;
        private Button saveBtn;
        private Label label5;
        private PictureBox categoryPictureBx;
        private RichTextBox descriptionRichTxt;
        private ComboBox categoryComboBx;
        private Button imageBrowseBtn;
    }
}
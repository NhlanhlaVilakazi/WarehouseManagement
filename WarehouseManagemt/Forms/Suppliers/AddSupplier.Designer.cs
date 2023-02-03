namespace WarehouseManagent.Forms.Supplier
{
    partial class AddSupplierForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.addressRichTxt = new System.Windows.Forms.RichTextBox();
            this.companyNameTxt = new System.Windows.Forms.TextBox();
            this.homePageTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.contactNameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.faxTxt = new System.Windows.Forms.TextBox();
            this.postalCodeTxt = new System.Windows.Forms.TextBox();
            this.regionTxt = new System.Windows.Forms.TextBox();
            this.contactTitleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.contactTitleErrorMsg = new System.Windows.Forms.Label();
            this.companyNameErrorMsg = new System.Windows.Forms.Label();
            this.contactNameErrorMsg = new System.Windows.Forms.Label();
            this.cityErrorMsg = new System.Windows.Forms.Label();
            this.postalCodeErrorMsg = new System.Windows.Forms.Label();
            this.phoneErrorMsg = new System.Windows.Forms.Label();
            this.countryErrorMsg = new System.Windows.Forms.Label();
            this.addressErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(614, 435);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 27;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addressRichTxt
            // 
            this.addressRichTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressRichTxt.Location = new System.Drawing.Point(505, 96);
            this.addressRichTxt.Name = "addressRichTxt";
            this.addressRichTxt.Size = new System.Drawing.Size(184, 144);
            this.addressRichTxt.TabIndex = 26;
            this.addressRichTxt.Text = "";
            this.addressRichTxt.TextChanged += new System.EventHandler(this.addressRichTxt_TextChanged);
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companyNameTxt.Location = new System.Drawing.Point(505, 30);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(184, 23);
            this.companyNameTxt.TabIndex = 25;
            this.companyNameTxt.TextChanged += new System.EventHandler(this.companyNameTxt_TextChanged);
            // 
            // homePageTxt
            // 
            this.homePageTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePageTxt.Location = new System.Drawing.Point(249, 398);
            this.homePageTxt.Name = "homePageTxt";
            this.homePageTxt.Size = new System.Drawing.Size(440, 23);
            this.homePageTxt.TabIndex = 24;
            // 
            // cityTxt
            // 
            this.cityTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityTxt.Location = new System.Drawing.Point(249, 156);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(184, 23);
            this.cityTxt.TabIndex = 23;
            this.cityTxt.TextChanged += new System.EventHandler(this.cityTxt_TextChanged);
            // 
            // contactNameTxt
            // 
            this.contactNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactNameTxt.Location = new System.Drawing.Point(249, 96);
            this.contactNameTxt.Name = "contactNameTxt";
            this.contactNameTxt.Size = new System.Drawing.Size(184, 23);
            this.contactNameTxt.TabIndex = 22;
            this.contactNameTxt.TextChanged += new System.EventHandler(this.contactNameTxt_TextChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTxt.Location = new System.Drawing.Point(249, 338);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(184, 23);
            this.phoneTxt.TabIndex = 21;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // countryTxt
            // 
            this.countryTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryTxt.Location = new System.Drawing.Point(505, 279);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(184, 23);
            this.countryTxt.TabIndex = 20;
            this.countryTxt.TextChanged += new System.EventHandler(this.countryTxt_TextChanged);
            // 
            // faxTxt
            // 
            this.faxTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faxTxt.Location = new System.Drawing.Point(505, 338);
            this.faxTxt.Name = "faxTxt";
            this.faxTxt.Size = new System.Drawing.Size(184, 23);
            this.faxTxt.TabIndex = 19;
            // 
            // postalCodeTxt
            // 
            this.postalCodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postalCodeTxt.Location = new System.Drawing.Point(249, 279);
            this.postalCodeTxt.Name = "postalCodeTxt";
            this.postalCodeTxt.Size = new System.Drawing.Size(184, 23);
            this.postalCodeTxt.TabIndex = 18;
            this.postalCodeTxt.TextChanged += new System.EventHandler(this.postalCodeTxt_TextChanged);
            // 
            // regionTxt
            // 
            this.regionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regionTxt.Location = new System.Drawing.Point(249, 218);
            this.regionTxt.Name = "regionTxt";
            this.regionTxt.Size = new System.Drawing.Size(184, 23);
            this.regionTxt.TabIndex = 17;
            // 
            // contactTitleTxt
            // 
            this.contactTitleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTitleTxt.Location = new System.Drawing.Point(249, 30);
            this.contactTitleTxt.Name = "contactTitleTxt";
            this.contactTitleTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactTitleTxt.Size = new System.Drawing.Size(184, 23);
            this.contactTitleTxt.TabIndex = 16;
            this.contactTitleTxt.TextChanged += new System.EventHandler(this.contactTitleTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Contact Title";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(249, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Region";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(505, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(249, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(505, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(249, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Contact Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(505, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Company Name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(249, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(505, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fax";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(249, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(249, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "Home Page";
            // 
            // contactTitleErrorMsg
            // 
            this.contactTitleErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTitleErrorMsg.AutoSize = true;
            this.contactTitleErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactTitleErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.contactTitleErrorMsg.Location = new System.Drawing.Point(249, 56);
            this.contactTitleErrorMsg.Name = "contactTitleErrorMsg";
            this.contactTitleErrorMsg.Size = new System.Drawing.Size(113, 15);
            this.contactTitleErrorMsg.TabIndex = 92;
            this.contactTitleErrorMsg.Text = "Please contact title";
            this.contactTitleErrorMsg.Visible = false;
            // 
            // companyNameErrorMsg
            // 
            this.companyNameErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companyNameErrorMsg.AutoSize = true;
            this.companyNameErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.companyNameErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.companyNameErrorMsg.Location = new System.Drawing.Point(505, 56);
            this.companyNameErrorMsg.Name = "companyNameErrorMsg";
            this.companyNameErrorMsg.Size = new System.Drawing.Size(161, 15);
            this.companyNameErrorMsg.TabIndex = 93;
            this.companyNameErrorMsg.Text = "Please input company name";
            this.companyNameErrorMsg.Visible = false;
            // 
            // contactNameErrorMsg
            // 
            this.contactNameErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactNameErrorMsg.AutoSize = true;
            this.contactNameErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactNameErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.contactNameErrorMsg.Location = new System.Drawing.Point(249, 122);
            this.contactNameErrorMsg.Name = "contactNameErrorMsg";
            this.contactNameErrorMsg.Size = new System.Drawing.Size(153, 15);
            this.contactNameErrorMsg.TabIndex = 94;
            this.contactNameErrorMsg.Text = "Please input contact name";
            this.contactNameErrorMsg.Visible = false;
            // 
            // cityErrorMsg
            // 
            this.cityErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityErrorMsg.AutoSize = true;
            this.cityErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.cityErrorMsg.Location = new System.Drawing.Point(249, 181);
            this.cityErrorMsg.Name = "cityErrorMsg";
            this.cityErrorMsg.Size = new System.Drawing.Size(131, 15);
            this.cityErrorMsg.TabIndex = 95;
            this.cityErrorMsg.Text = "Please input city name";
            this.cityErrorMsg.Visible = false;
            // 
            // postalCodeErrorMsg
            // 
            this.postalCodeErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postalCodeErrorMsg.AutoSize = true;
            this.postalCodeErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postalCodeErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.postalCodeErrorMsg.Location = new System.Drawing.Point(249, 302);
            this.postalCodeErrorMsg.Name = "postalCodeErrorMsg";
            this.postalCodeErrorMsg.Size = new System.Drawing.Size(140, 15);
            this.postalCodeErrorMsg.TabIndex = 97;
            this.postalCodeErrorMsg.Text = "Please input postal code";
            this.postalCodeErrorMsg.Visible = false;
            // 
            // phoneErrorMsg
            // 
            this.phoneErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneErrorMsg.AutoSize = true;
            this.phoneErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorMsg.Location = new System.Drawing.Point(249, 363);
            this.phoneErrorMsg.Name = "phoneErrorMsg";
            this.phoneErrorMsg.Size = new System.Drawing.Size(159, 15);
            this.phoneErrorMsg.TabIndex = 98;
            this.phoneErrorMsg.Text = "Please input phone number";
            this.phoneErrorMsg.Visible = false;
            // 
            // countryErrorMsg
            // 
            this.countryErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryErrorMsg.AutoSize = true;
            this.countryErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countryErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.countryErrorMsg.Location = new System.Drawing.Point(505, 302);
            this.countryErrorMsg.Name = "countryErrorMsg";
            this.countryErrorMsg.Size = new System.Drawing.Size(154, 15);
            this.countryErrorMsg.TabIndex = 100;
            this.countryErrorMsg.Text = "Please input country name";
            this.countryErrorMsg.Visible = false;
            // 
            // addressErrorMsg
            // 
            this.addressErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressErrorMsg.AutoSize = true;
            this.addressErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.addressErrorMsg.Location = new System.Drawing.Point(505, 243);
            this.addressErrorMsg.Name = "addressErrorMsg";
            this.addressErrorMsg.Size = new System.Drawing.Size(119, 15);
            this.addressErrorMsg.TabIndex = 102;
            this.addressErrorMsg.Text = "Please input address";
            this.addressErrorMsg.Visible = false;
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 466);
            this.Controls.Add(this.addressErrorMsg);
            this.Controls.Add(this.countryErrorMsg);
            this.Controls.Add(this.phoneErrorMsg);
            this.Controls.Add(this.postalCodeErrorMsg);
            this.Controls.Add(this.cityErrorMsg);
            this.Controls.Add(this.contactNameErrorMsg);
            this.Controls.Add(this.companyNameErrorMsg);
            this.Controls.Add(this.contactTitleErrorMsg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addressRichTxt);
            this.Controls.Add(this.companyNameTxt);
            this.Controls.Add(this.homePageTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.contactNameTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.countryTxt);
            this.Controls.Add(this.faxTxt);
            this.Controls.Add(this.postalCodeTxt);
            this.Controls.Add(this.regionTxt);
            this.Controls.Add(this.contactTitleTxt);
            this.Name = "AddSupplierForm";
            this.Text = "Add Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button saveBtn;
        private RichTextBox addressRichTxt;
        private TextBox companyNameTxt;
        private TextBox homePageTxt;
        private TextBox cityTxt;
        private TextBox contactNameTxt;
        private TextBox phoneTxt;
        private TextBox countryTxt;
        private TextBox faxTxt;
        private TextBox postalCodeTxt;
        private TextBox regionTxt;
        private TextBox contactTitleTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label contactTitleErrorMsg;
        private Label companyNameErrorMsg;
        private Label contactNameErrorMsg;
        private Label cityErrorMsg;
        private Label postalCodeErrorMsg;
        private Label phoneErrorMsg;
        private Label countryErrorMsg;
        private Label addressErrorMsg;
    }
}
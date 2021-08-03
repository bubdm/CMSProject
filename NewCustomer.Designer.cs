namespace CMSProject
{
    partial class NewCustomerFrm
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
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_dateOfBirth = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_emailAddress = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_suburb = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_postCode = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_emailAddress = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_suburb = new System.Windows.Forms.TextBox();
            this.tb_postCode = new System.Windows.Forms.TextBox();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Other = new System.Windows.Forms.RadioButton();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.field_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Location = new System.Drawing.Point(187, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(987, 110);
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(183, 280);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(111, 23);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "First Name";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(183, 329);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(108, 23);
            this.lbl_lastName.TabIndex = 3;
            this.lbl_lastName.Text = "Last Name";
            // 
            // lbl_dateOfBirth
            // 
            this.lbl_dateOfBirth.AutoSize = true;
            this.lbl_dateOfBirth.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateOfBirth.Location = new System.Drawing.Point(183, 378);
            this.lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            this.lbl_dateOfBirth.Size = new System.Drawing.Size(126, 23);
            this.lbl_dateOfBirth.TabIndex = 4;
            this.lbl_dateOfBirth.Text = "Date of Birth";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(183, 476);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(76, 23);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(768, 280);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(145, 23);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lbl_emailAddress
            // 
            this.lbl_emailAddress.AutoSize = true;
            this.lbl_emailAddress.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailAddress.Location = new System.Drawing.Point(183, 430);
            this.lbl_emailAddress.Name = "lbl_emailAddress";
            this.lbl_emailAddress.Size = new System.Drawing.Size(141, 23);
            this.lbl_emailAddress.TabIndex = 7;
            this.lbl_emailAddress.Text = "Email Address";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(768, 329);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(141, 23);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Street Address";
            // 
            // lbl_suburb
            // 
            this.lbl_suburb.AutoSize = true;
            this.lbl_suburb.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suburb.Location = new System.Drawing.Point(768, 378);
            this.lbl_suburb.Name = "lbl_suburb";
            this.lbl_suburb.Size = new System.Drawing.Size(76, 23);
            this.lbl_suburb.TabIndex = 9;
            this.lbl_suburb.Text = "Suburb";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(768, 427);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(47, 23);
            this.lbl_city.TabIndex = 10;
            this.lbl_city.Text = "City";
            // 
            // lbl_postCode
            // 
            this.lbl_postCode.AutoSize = true;
            this.lbl_postCode.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postCode.Location = new System.Drawing.Point(768, 476);
            this.lbl_postCode.Name = "lbl_postCode";
            this.lbl_postCode.Size = new System.Drawing.Size(99, 23);
            this.lbl_postCode.TabIndex = 11;
            this.lbl_postCode.Text = "Post Code";
            // 
            // tb_firstName
            // 
            this.tb_firstName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_firstName.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_firstName.Location = new System.Drawing.Point(341, 282);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(208, 24);
            this.tb_firstName.TabIndex = 12;
            // 
            // tb_lastName
            // 
            this.tb_lastName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_lastName.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_lastName.Location = new System.Drawing.Point(341, 331);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(208, 24);
            this.tb_lastName.TabIndex = 13;
            // 
            // tb_emailAddress
            // 
            this.tb_emailAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tb_emailAddress.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_emailAddress.Location = new System.Drawing.Point(341, 429);
            this.tb_emailAddress.Name = "tb_emailAddress";
            this.tb_emailAddress.Size = new System.Drawing.Size(208, 24);
            this.tb_emailAddress.TabIndex = 15;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.SystemColors.Window;
            this.tb_phone.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_phone.Location = new System.Drawing.Point(961, 282);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(213, 24);
            this.tb_phone.TabIndex = 16;
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.SystemColors.Window;
            this.tb_address.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_address.Location = new System.Drawing.Point(961, 331);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(213, 24);
            this.tb_address.TabIndex = 17;
            // 
            // tb_suburb
            // 
            this.tb_suburb.BackColor = System.Drawing.SystemColors.Window;
            this.tb_suburb.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_suburb.Location = new System.Drawing.Point(961, 380);
            this.tb_suburb.Name = "tb_suburb";
            this.tb_suburb.Size = new System.Drawing.Size(213, 24);
            this.tb_suburb.TabIndex = 18;
            // 
            // tb_postCode
            // 
            this.tb_postCode.BackColor = System.Drawing.SystemColors.Window;
            this.tb_postCode.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_postCode.Location = new System.Drawing.Point(961, 478);
            this.tb_postCode.Name = "tb_postCode";
            this.tb_postCode.Size = new System.Drawing.Size(213, 24);
            this.tb_postCode.TabIndex = 20;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Font = new System.Drawing.Font("Century", 10.25F);
            this.rbtn_Male.Location = new System.Drawing.Point(341, 478);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(58, 21);
            this.rbtn_Male.TabIndex = 21;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Font = new System.Drawing.Font("Century", 10.25F);
            this.rbtn_Female.Location = new System.Drawing.Point(405, 478);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(73, 21);
            this.rbtn_Female.TabIndex = 22;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // rbtn_Other
            // 
            this.rbtn_Other.AutoSize = true;
            this.rbtn_Other.Font = new System.Drawing.Font("Century", 10.25F);
            this.rbtn_Other.Location = new System.Drawing.Point(485, 478);
            this.rbtn_Other.Name = "rbtn_Other";
            this.rbtn_Other.Size = new System.Drawing.Size(64, 21);
            this.rbtn_Other.TabIndex = 23;
            this.rbtn_Other.TabStop = true;
            this.rbtn_Other.Text = "Other";
            this.rbtn_Other.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Century", 14.25F);
            this.btn_Submit.Location = new System.Drawing.Point(485, 603);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(175, 32);
            this.btn_Submit.TabIndex = 24;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Century", 14.25F);
            this.btn_Clear.Location = new System.Drawing.Point(692, 603);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(175, 32);
            this.btn_Clear.TabIndex = 25;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cb_city
            // 
            this.cb_city.Font = new System.Drawing.Font("Century", 10.25F);
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Items.AddRange(new object[] {
            "Auckland",
            "Christchurch",
            "Wellington"});
            this.cb_city.Location = new System.Drawing.Point(961, 432);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(213, 25);
            this.cb_city.TabIndex = 26;
            this.cb_city.Text = "Select...";
            // 
            // field_dateOfBirth
            // 
            this.field_dateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.field_dateOfBirth.Font = new System.Drawing.Font("Century", 10.25F);
            this.field_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.field_dateOfBirth.Location = new System.Drawing.Point(341, 377);
            this.field_dateOfBirth.Name = "field_dateOfBirth";
            this.field_dateOfBirth.Size = new System.Drawing.Size(208, 24);
            this.field_dateOfBirth.TabIndex = 27;
            // 
            // NewCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 647);
            this.Controls.Add(this.field_dateOfBirth);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rbtn_Other);
            this.Controls.Add(this.rbtn_Female);
            this.Controls.Add(this.rbtn_Male);
            this.Controls.Add(this.tb_postCode);
            this.Controls.Add(this.tb_suburb);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_emailAddress);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.lbl_postCode);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_suburb);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_emailAddress);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_dateOfBirth);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.pb_Logo);
            this.Name = "NewCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.NewCustomerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_dateOfBirth;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_emailAddress;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_suburb;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_postCode;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_emailAddress;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_suburb;
        private System.Windows.Forms.TextBox tb_postCode;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Other;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.DateTimePicker field_dateOfBirth;
    }
}
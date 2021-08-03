namespace CMSProject
{
    partial class SearchCustomerFrm
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
            this.pb_searchIcon = new System.Windows.Forms.PictureBox();
            this.data_searchResults = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.lbl_dateOfBirth = new System.Windows.Forms.Label();
            this.tb_dateOfBirth = new System.Windows.Forms.TextBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_searchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_searchIcon
            // 
            this.pb_searchIcon.Location = new System.Drawing.Point(13, 13);
            this.pb_searchIcon.Name = "pb_searchIcon";
            this.pb_searchIcon.Size = new System.Drawing.Size(126, 119);
            this.pb_searchIcon.TabIndex = 0;
            this.pb_searchIcon.TabStop = false;
            // 
            // data_searchResults
            // 
            this.data_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_searchResults.Location = new System.Drawing.Point(143, 153);
            this.data_searchResults.Name = "data_searchResults";
            this.data_searchResults.Size = new System.Drawing.Size(1060, 482);
            this.data_searchResults.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Century", 10.25F);
            this.btn_Search.Location = new System.Drawing.Point(306, 108);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(156, 24);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Century", 12.25F);
            this.lbl_lastName.Location = new System.Drawing.Point(177, 16);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(97, 21);
            this.lbl_lastName.TabIndex = 5;
            this.lbl_lastName.Text = "Last Name";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_lastName.Location = new System.Drawing.Point(306, 15);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(156, 24);
            this.tb_lastName.TabIndex = 6;
            // 
            // lbl_dateOfBirth
            // 
            this.lbl_dateOfBirth.AutoSize = true;
            this.lbl_dateOfBirth.Font = new System.Drawing.Font("Century", 12.25F);
            this.lbl_dateOfBirth.Location = new System.Drawing.Point(159, 65);
            this.lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            this.lbl_dateOfBirth.Size = new System.Drawing.Size(115, 21);
            this.lbl_dateOfBirth.TabIndex = 7;
            this.lbl_dateOfBirth.Text = "Date of Birth";
            // 
            // tb_dateOfBirth
            // 
            this.tb_dateOfBirth.Font = new System.Drawing.Font("Century", 10.25F);
            this.tb_dateOfBirth.Location = new System.Drawing.Point(306, 64);
            this.tb_dateOfBirth.Name = "tb_dateOfBirth";
            this.tb_dateOfBirth.Size = new System.Drawing.Size(156, 24);
            this.tb_dateOfBirth.TabIndex = 8;
            // 
            // btn_showAll
            // 
            this.btn_showAll.Font = new System.Drawing.Font("Century", 10.25F);
            this.btn_showAll.Location = new System.Drawing.Point(1047, 108);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(156, 24);
            this.btn_showAll.TabIndex = 9;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = true;
            // 
            // SearchCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 647);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.tb_dateOfBirth);
            this.Controls.Add(this.lbl_dateOfBirth);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.data_searchResults);
            this.Controls.Add(this.pb_searchIcon);
            this.Name = "SearchCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pb_searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_searchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_searchIcon;
        private System.Windows.Forms.DataGridView data_searchResults;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label lbl_dateOfBirth;
        private System.Windows.Forms.TextBox tb_dateOfBirth;
        private System.Windows.Forms.Button btn_showAll;
    }
}
namespace eDrivingSchool.WinUI.TheoryTestApplications
{
    partial class frmTheoryTestApplicationsData
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTheoryTestApplicationsData = new System.Windows.Forms.DataGridView();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstAid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoryTestApplicationsData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvTheoryTestApplicationsData
            // 
            this.dgvTheoryTestApplicationsData.AllowUserToAddRows = false;
            this.dgvTheoryTestApplicationsData.AllowUserToDeleteRows = false;
            this.dgvTheoryTestApplicationsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheoryTestApplicationsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Category,
            this.TheoryTest,
            this.FirstAid,
            this.Date,
            this.Active});
            this.dgvTheoryTestApplicationsData.Location = new System.Drawing.Point(12, 64);
            this.dgvTheoryTestApplicationsData.Name = "dgvTheoryTestApplicationsData";
            this.dgvTheoryTestApplicationsData.ReadOnly = true;
            this.dgvTheoryTestApplicationsData.RowTemplate.Height = 24;
            this.dgvTheoryTestApplicationsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheoryTestApplicationsData.Size = new System.Drawing.Size(1100, 362);
            this.dgvTheoryTestApplicationsData.TabIndex = 3;
            this.dgvTheoryTestApplicationsData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvTheoryTestApplicationsData_MouseDoubleClick);
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(441, 12);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(68, 21);
            this.checkBoxActive.TabIndex = 4;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // TheoryTest
            // 
            this.TheoryTest.DataPropertyName = "TheoryTest";
            this.TheoryTest.HeaderText = "TheoryTest";
            this.TheoryTest.Name = "TheoryTest";
            this.TheoryTest.ReadOnly = true;
            // 
            // FirstAid
            // 
            this.FirstAid.DataPropertyName = "FirstAid";
            this.FirstAid.HeaderText = "First aid";
            this.FirstAid.Name = "FirstAid";
            this.FirstAid.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // frmTheoryTestApplicationsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.dgvTheoryTestApplicationsData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmTheoryTestApplicationsData";
            this.Text = "frmTheoryTestApplicationsData";
            this.Load += new System.EventHandler(this.FrmTheoryTestApplicationsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoryTestApplicationsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTheoryTestApplicationsData;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstAid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}
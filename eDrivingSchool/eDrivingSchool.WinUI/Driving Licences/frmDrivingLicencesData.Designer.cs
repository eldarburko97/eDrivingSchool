namespace eDrivingSchool.WinUI.Driving_Licences
{
    partial class frmDrivingLicencesData
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
            this.dgvDrivingLicencesData = new System.Windows.Forms.DataGridView();
            this.Instructor_Category_CandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfLessons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicencesData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvDrivingLicencesData
            // 
            this.dgvDrivingLicencesData.AllowUserToAddRows = false;
            this.dgvDrivingLicencesData.AllowUserToDeleteRows = false;
            this.dgvDrivingLicencesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivingLicencesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instructor_Category_CandidateId,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Category,
            this.NumberOfLessons,
            this.Paid,
            this.Date});
            this.dgvDrivingLicencesData.Location = new System.Drawing.Point(32, 56);
            this.dgvDrivingLicencesData.Name = "dgvDrivingLicencesData";
            this.dgvDrivingLicencesData.ReadOnly = true;
            this.dgvDrivingLicencesData.RowTemplate.Height = 24;
            this.dgvDrivingLicencesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivingLicencesData.Size = new System.Drawing.Size(1389, 362);
            this.dgvDrivingLicencesData.TabIndex = 5;
            this.dgvDrivingLicencesData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvDrivingLicencesData_MouseDoubleClick);
            // 
            // Instructor_Category_CandidateId
            // 
            this.Instructor_Category_CandidateId.DataPropertyName = "Instructor_Category_CandidateId";
            this.Instructor_Category_CandidateId.HeaderText = "Id";
            this.Instructor_Category_CandidateId.Name = "Instructor_Category_CandidateId";
            this.Instructor_Category_CandidateId.ReadOnly = true;
            this.Instructor_Category_CandidateId.Visible = false;
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
            // NumberOfLessons
            // 
            this.NumberOfLessons.DataPropertyName = "NumberOfLessons";
            this.NumberOfLessons.HeaderText = "Number of lessons";
            this.NumberOfLessons.Name = "NumberOfLessons";
            this.NumberOfLessons.ReadOnly = true;
            // 
            // Paid
            // 
            this.Paid.DataPropertyName = "Paid";
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // frmDrivingLicencesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 450);
            this.Controls.Add(this.dgvDrivingLicencesData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmDrivingLicencesData";
            this.Text = "frmDrivingLicencesData";
            this.Load += new System.EventHandler(this.FrmDrivingLicencesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicencesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDrivingLicencesData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor_Category_CandidateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
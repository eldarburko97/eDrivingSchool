namespace eDrivingSchool.WinUI.DrivingTest
{
    partial class frmDrivingTestData
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
            this.dgvDrivingTestData = new System.Windows.Forms.DataGridView();
            this.Instructor_Category_CandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingTestPassed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingTestData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(272, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
           // this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvDrivingTestData
            // 
            this.dgvDrivingTestData.AllowUserToAddRows = false;
            this.dgvDrivingTestData.AllowUserToDeleteRows = false;
            this.dgvDrivingTestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivingTestData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instructor_Category_CandidateId,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Category,
            this.DrivingTestPassed});
            this.dgvDrivingTestData.Location = new System.Drawing.Point(12, 66);
            this.dgvDrivingTestData.Name = "dgvDrivingTestData";
            this.dgvDrivingTestData.ReadOnly = true;
            this.dgvDrivingTestData.RowTemplate.Height = 24;
            this.dgvDrivingTestData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivingTestData.Size = new System.Drawing.Size(1290, 362);
            this.dgvDrivingTestData.TabIndex = 4;
           // this.dgvDrivingTestData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvDrivingTestData_MouseDoubleClick);
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
            // DrivingTestPassed
            // 
            this.DrivingTestPassed.DataPropertyName = "DrivingTestPassed";
            this.DrivingTestPassed.HeaderText = "Driving test passed";
            this.DrivingTestPassed.Name = "DrivingTestPassed";
            this.DrivingTestPassed.ReadOnly = true;
            // 
            // frmDrivingTestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 450);
            this.Controls.Add(this.dgvDrivingTestData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmDrivingTestData";
            this.Text = "frmDrivingTestData";
           // this.Load += new System.EventHandler(this.FrmDrivingTestData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingTestData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDrivingTestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor_Category_CandidateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingTestPassed;
    }
}
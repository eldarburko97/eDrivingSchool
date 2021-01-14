namespace eDrivingSchool.WinUI.DrivingLicenceCondition
{
    partial class frmDrivingLicenceData
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
            this.dgvDrivingLicenceData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozenTestPrvePomoci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozenPrakticniTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozenTeorijskiTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijavljen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfLessons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicenceData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvDrivingLicenceData
            // 
            this.dgvDrivingLicenceData.AllowUserToAddRows = false;
            this.dgvDrivingLicenceData.AllowUserToDeleteRows = false;
            this.dgvDrivingLicenceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivingLicenceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.PolozenTestPrvePomoci,
            this.PolozenPrakticniTest,
            this.PolozenTeorijskiTest,
            this.Prijavljen,
            this.NumberOfLessons,
            this.Paid});
            this.dgvDrivingLicenceData.Location = new System.Drawing.Point(26, 76);
            this.dgvDrivingLicenceData.Name = "dgvDrivingLicenceData";
            this.dgvDrivingLicenceData.ReadOnly = true;
            this.dgvDrivingLicenceData.RowTemplate.Height = 24;
            this.dgvDrivingLicenceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivingLicenceData.Size = new System.Drawing.Size(996, 362);
            this.dgvDrivingLicenceData.TabIndex = 3;
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
            // PolozenTestPrvePomoci
            // 
            this.PolozenTestPrvePomoci.DataPropertyName = "PolozenTestPrvePomoci";
            this.PolozenTestPrvePomoci.HeaderText = "PolozenTestPrvePomoci";
            this.PolozenTestPrvePomoci.Name = "PolozenTestPrvePomoci";
            this.PolozenTestPrvePomoci.ReadOnly = true;
            // 
            // PolozenPrakticniTest
            // 
            this.PolozenPrakticniTest.DataPropertyName = "PolozenPrakticniTest";
            this.PolozenPrakticniTest.HeaderText = "PolozenPrakticniTest";
            this.PolozenPrakticniTest.Name = "PolozenPrakticniTest";
            this.PolozenPrakticniTest.ReadOnly = true;
            // 
            // PolozenTeorijskiTest
            // 
            this.PolozenTeorijskiTest.DataPropertyName = "PolozenTeorijskiTest";
            this.PolozenTeorijskiTest.HeaderText = "PolozenTeorijskiTest";
            this.PolozenTeorijskiTest.Name = "PolozenTeorijskiTest";
            this.PolozenTeorijskiTest.ReadOnly = true;
            // 
            // Prijavljen
            // 
            this.Prijavljen.DataPropertyName = "Prijavljen";
            this.Prijavljen.HeaderText = "Prijavljen";
            this.Prijavljen.Name = "Prijavljen";
            this.Prijavljen.ReadOnly = true;
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
            // frmDrivingLicenceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.dgvDrivingLicenceData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmDrivingLicenceData";
            this.Text = "frmDrivingLicenceData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicenceData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDrivingLicenceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozenTestPrvePomoci;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozenPrakticniTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozenTeorijskiTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijavljen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
    }
}
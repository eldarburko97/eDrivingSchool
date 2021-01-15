namespace eDrivingSchool.WinUI.TheoryTest
{
    partial class frmTheoryTestData
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
            this.dgvTheoryTestData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozenTeorijskiTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozenTestPrvePomoci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoryTestData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(285, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvTheoryTestData
            // 
            this.dgvTheoryTestData.AllowUserToAddRows = false;
            this.dgvTheoryTestData.AllowUserToDeleteRows = false;
            this.dgvTheoryTestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheoryTestData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Category,
            this.PolozenTeorijskiTest,
            this.PolozenTestPrvePomoci});
            this.dgvTheoryTestData.Location = new System.Drawing.Point(12, 76);
            this.dgvTheoryTestData.Name = "dgvTheoryTestData";
            this.dgvTheoryTestData.ReadOnly = true;
            this.dgvTheoryTestData.RowTemplate.Height = 24;
            this.dgvTheoryTestData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheoryTestData.Size = new System.Drawing.Size(1014, 362);
            this.dgvTheoryTestData.TabIndex = 3;
            this.dgvTheoryTestData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvTheoryTestData_MouseDoubleClick);
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
            // PolozenTeorijskiTest
            // 
            this.PolozenTeorijskiTest.DataPropertyName = "PolozenTeorijskiTest";
            this.PolozenTeorijskiTest.HeaderText = "Polozen teorijski test";
            this.PolozenTeorijskiTest.Name = "PolozenTeorijskiTest";
            this.PolozenTeorijskiTest.ReadOnly = true;
            // 
            // PolozenTestPrvePomoci
            // 
            this.PolozenTestPrvePomoci.DataPropertyName = "PolozenTestPrvePomoci";
            this.PolozenTestPrvePomoci.HeaderText = "Polozen test prve pomoci";
            this.PolozenTestPrvePomoci.Name = "PolozenTestPrvePomoci";
            this.PolozenTestPrvePomoci.ReadOnly = true;
            // 
            // frmTheoryTestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.dgvTheoryTestData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmTheoryTestData";
            this.Text = "frmTheoryTestData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoryTestData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTheoryTestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozenTeorijskiTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozenTestPrvePomoci;
    }
}
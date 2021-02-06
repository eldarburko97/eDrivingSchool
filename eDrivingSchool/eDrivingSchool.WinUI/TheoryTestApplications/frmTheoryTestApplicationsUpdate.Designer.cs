namespace eDrivingSchool.WinUI.TheoryTestApplications
{
    partial class frmTheoryTestApplicationsUpdate
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatuses = new System.Windows.Forms.ComboBox();
            this.checkBoxPolozenTestPrvePomoci = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxPolozenTeorijskiIspit = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(35, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(288, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(35, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(288, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(35, 181);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(288, 22);
            this.txtUsername.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(36, 241);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(287, 22);
            this.txtCategory.TabIndex = 20;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(35, 304);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(288, 22);
            this.txtDate.TabIndex = 22;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbStatuses
            // 
            this.cmbStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatuses.FormattingEnabled = true;
            this.cmbStatuses.Location = new System.Drawing.Point(528, 277);
            this.cmbStatuses.Name = "cmbStatuses";
            this.cmbStatuses.Size = new System.Drawing.Size(173, 24);
            this.cmbStatuses.TabIndex = 24;
            // 
            // checkBoxPolozenTestPrvePomoci
            // 
            this.checkBoxPolozenTestPrvePomoci.AutoSize = true;
            this.checkBoxPolozenTestPrvePomoci.Location = new System.Drawing.Point(245, 432);
            this.checkBoxPolozenTestPrvePomoci.Name = "checkBoxPolozenTestPrvePomoci";
            this.checkBoxPolozenTestPrvePomoci.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPolozenTestPrvePomoci.TabIndex = 29;
            this.checkBoxPolozenTestPrvePomoci.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Polozen test prve pomoci";
            // 
            // checkBoxPolozenTeorijskiIspit
            // 
            this.checkBoxPolozenTeorijskiIspit.AutoSize = true;
            this.checkBoxPolozenTeorijskiIspit.Location = new System.Drawing.Point(245, 372);
            this.checkBoxPolozenTeorijskiIspit.Name = "checkBoxPolozenTeorijskiIspit";
            this.checkBoxPolozenTeorijskiIspit.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPolozenTeorijskiIspit.TabIndex = 27;
            this.checkBoxPolozenTeorijskiIspit.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Polozen teorijski ispit";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(245, 489);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(18, 17);
            this.checkBoxActive.TabIndex = 31;
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Active";
            // 
            // frmTheoryTestApplicationsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 655);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxPolozenTestPrvePomoci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxPolozenTeorijskiIspit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbStatuses);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmTheoryTestApplicationsUpdate";
            this.Text = "frmTheoryTestApplicationsUpdate";
            this.Load += new System.EventHandler(this.FrmTheoryTestApplicationsUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbStatuses;
        private System.Windows.Forms.CheckBox checkBoxPolozenTestPrvePomoci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxPolozenTeorijskiIspit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label label7;
    }
}
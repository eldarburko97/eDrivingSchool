namespace eDrivingSchool.WinUI
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.instructorsToolStripMenuItem,
            this.candidatesToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.drivingToolStripMenuItem.Text = "Driving school";
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstructorToolStripMenuItem,
            this.instructorDataToolStripMenuItem});
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.instructorsToolStripMenuItem.Text = "Instructors";
            // 
            // addInstructorToolStripMenuItem
            // 
            this.addInstructorToolStripMenuItem.Name = "addInstructorToolStripMenuItem";
            this.addInstructorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addInstructorToolStripMenuItem.Text = "Add Instructor";
            this.addInstructorToolStripMenuItem.Click += new System.EventHandler(this.AddInstructorToolStripMenuItem_Click);
            // 
            // instructorDataToolStripMenuItem
            // 
            this.instructorDataToolStripMenuItem.Name = "instructorDataToolStripMenuItem";
            this.instructorDataToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.instructorDataToolStripMenuItem.Text = "Instructor data";
            this.instructorDataToolStripMenuItem.Click += new System.EventHandler(this.InstructorDataToolStripMenuItem_Click);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCandidateToolStripMenuItem,
            this.candidatesDataToolStripMenuItem});
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.candidatesToolStripMenuItem.Text = "Candidates";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addCandidateToolStripMenuItem.Text = "Add candidate";
            this.addCandidateToolStripMenuItem.Click += new System.EventHandler(this.AddCandidateToolStripMenuItem_Click);
            // 
            // candidatesDataToolStripMenuItem
            // 
            this.candidatesDataToolStripMenuItem.Name = "candidatesDataToolStripMenuItem";
            this.candidatesDataToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.candidatesDataToolStripMenuItem.Text = "Candidate data";
            this.candidatesDataToolStripMenuItem.Click += new System.EventHandler(this.CandidatesDataToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.paymentDataToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addPaymentToolStripMenuItem.Text = "Add payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.AddPaymentToolStripMenuItem_Click);
            // 
            // paymentDataToolStripMenuItem
            // 
            this.paymentDataToolStripMenuItem.Name = "paymentDataToolStripMenuItem";
            this.paymentDataToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.paymentDataToolStripMenuItem.Text = "Payment data";
            this.paymentDataToolStripMenuItem.Click += new System.EventHandler(this.PaymentDataToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDataToolStripMenuItem;
    }
}




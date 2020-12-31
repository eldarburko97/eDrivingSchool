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
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataOfSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOfVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOfCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalInspectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTechnicalInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOfTechnicalInspectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.paymentsToolStripMenuItem,
            this.technicalInspectionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataOfSchoolToolStripMenuItem});
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.drivingToolStripMenuItem.Text = "Driving school";
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVehicleToolStripMenuItem,
            this.dataOfVehiclesToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.dataOfCategoriesToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstructorToolStripMenuItem,
            this.instructorDataToolStripMenuItem});
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.instructorsToolStripMenuItem.Text = "Instructors";
            // 
            // addInstructorToolStripMenuItem
            // 
            this.addInstructorToolStripMenuItem.Name = "addInstructorToolStripMenuItem";
            this.addInstructorToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addInstructorToolStripMenuItem.Text = "Add Instructor";
            this.addInstructorToolStripMenuItem.Click += new System.EventHandler(this.AddInstructorToolStripMenuItem_Click);
            // 
            // instructorDataToolStripMenuItem
            // 
            this.instructorDataToolStripMenuItem.Name = "instructorDataToolStripMenuItem";
            this.instructorDataToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.instructorDataToolStripMenuItem.Text = "Instructor data";
            this.instructorDataToolStripMenuItem.Click += new System.EventHandler(this.InstructorDataToolStripMenuItem_Click);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCandidateToolStripMenuItem,
            this.candidatesDataToolStripMenuItem});
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.candidatesToolStripMenuItem.Text = "Candidates";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addCandidateToolStripMenuItem.Text = "Add candidate";
            this.addCandidateToolStripMenuItem.Click += new System.EventHandler(this.AddCandidateToolStripMenuItem_Click);
            // 
            // candidatesDataToolStripMenuItem
            // 
            this.candidatesDataToolStripMenuItem.Name = "candidatesDataToolStripMenuItem";
            this.candidatesDataToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.candidatesDataToolStripMenuItem.Text = "Candidate data";
            this.candidatesDataToolStripMenuItem.Click += new System.EventHandler(this.CandidatesDataToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.paymentDataToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.addPaymentToolStripMenuItem.Text = "Add payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.AddPaymentToolStripMenuItem_Click);
            // 
            // paymentDataToolStripMenuItem
            // 
            this.paymentDataToolStripMenuItem.Name = "paymentDataToolStripMenuItem";
            this.paymentDataToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.paymentDataToolStripMenuItem.Text = "Payment data";
            this.paymentDataToolStripMenuItem.Click += new System.EventHandler(this.PaymentDataToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // dataOfSchoolToolStripMenuItem
            // 
            this.dataOfSchoolToolStripMenuItem.Name = "dataOfSchoolToolStripMenuItem";
            this.dataOfSchoolToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.dataOfSchoolToolStripMenuItem.Text = "Data of  driving school";
            this.dataOfSchoolToolStripMenuItem.Click += new System.EventHandler(this.dataOfSchoolToolStripMenuItem_Click);
            // 
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewVehicleToolStripMenuItem.Text = "Add new vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicleToolStripMenuItem_Click);
            // 
            // dataOfVehiclesToolStripMenuItem
            // 
            this.dataOfVehiclesToolStripMenuItem.Name = "dataOfVehiclesToolStripMenuItem";
            this.dataOfVehiclesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataOfVehiclesToolStripMenuItem.Text = "Data of vehicles";
            this.dataOfVehiclesToolStripMenuItem.Click += new System.EventHandler(this.dataOfVehiclesToolStripMenuItem_Click);
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCategoryToolStripMenuItem.Text = "Add new category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click);
            // 
            // dataOfCategoriesToolStripMenuItem
            // 
            this.dataOfCategoriesToolStripMenuItem.Name = "dataOfCategoriesToolStripMenuItem";
            this.dataOfCategoriesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataOfCategoriesToolStripMenuItem.Text = "Data of categories";
            this.dataOfCategoriesToolStripMenuItem.Click += new System.EventHandler(this.dataOfCategoriesToolStripMenuItem_Click);
            // 
            // technicalInspectionsToolStripMenuItem
            // 
            this.technicalInspectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTechnicalInspectionToolStripMenuItem,
            this.dataOfTechnicalInspectionsToolStripMenuItem});
            this.technicalInspectionsToolStripMenuItem.Name = "technicalInspectionsToolStripMenuItem";
            this.technicalInspectionsToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.technicalInspectionsToolStripMenuItem.Text = "Technical inspections";
            // 
            // addNewTechnicalInspectionToolStripMenuItem
            // 
            this.addNewTechnicalInspectionToolStripMenuItem.Name = "addNewTechnicalInspectionToolStripMenuItem";
            this.addNewTechnicalInspectionToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.addNewTechnicalInspectionToolStripMenuItem.Text = "Add new technical inspection";
            this.addNewTechnicalInspectionToolStripMenuItem.Click += new System.EventHandler(this.addNewTechnicalInspectionToolStripMenuItem_Click);
            // 
            // dataOfTechnicalInspectionsToolStripMenuItem
            // 
            this.dataOfTechnicalInspectionsToolStripMenuItem.Name = "dataOfTechnicalInspectionsToolStripMenuItem";
            this.dataOfTechnicalInspectionsToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.dataOfTechnicalInspectionsToolStripMenuItem.Text = "Data of technical inspections";
            this.dataOfTechnicalInspectionsToolStripMenuItem.Click += new System.EventHandler(this.dataOfTechnicalInspectionsToolStripMenuItem_Click);
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
            this.Text = "Main form";
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
        private System.Windows.Forms.ToolStripMenuItem dataOfSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOfVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOfCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalInspectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTechnicalInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOfTechnicalInspectionsToolStripMenuItem;
    }
}




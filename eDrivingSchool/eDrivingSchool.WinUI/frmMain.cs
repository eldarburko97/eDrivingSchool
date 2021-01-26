using eDrivingSchool.WinUI.Candidate;
using eDrivingSchool.WinUI.Category;
using eDrivingSchool.WinUI.Certificate;
using eDrivingSchool.WinUI.CertificateRequests;
using eDrivingSchool.WinUI.Driving_Licences;
using eDrivingSchool.WinUI.DrivingTest;
using eDrivingSchool.WinUI.DrivingTestApplications;
using eDrivingSchool.WinUI.Instructor;
using eDrivingSchool.WinUI.Manufacturers;
using eDrivingSchool.WinUI.Payment;
using eDrivingSchool.WinUI.TechnicalInspection;
using eDrivingSchool.WinUI.TheoryTest;
using eDrivingSchool.WinUI.TheoryTestApplications;
using eDrivingSchool.WinUI.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        /*
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        */
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AddInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInstructor frm = new frmAddInstructor();
            frm.Show();
        }

        private void InstructorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Any(myForm => myForm.GetType() == typeof(frmInstructorData)))
            {

                frmInstructorData frm = new frmInstructorData()
                {
                    WindowState = FormWindowState.Maximized
                };
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void AddCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCandidate frm = new frmAddCandidate();
            frm.Show();
        }

        private void CandidatesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidatesData frm = new frmCandidatesData();
            frm.Show();
        }

        private void AddPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPayment frm = new frmAddPayment();
            frm.Show();
        }

        private void PaymentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentData frm = new frmPaymentData();
            frm.Show();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVehicle frm = new frmAddVehicle();
            frm.Show();
        }

        private void dataOfVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiclesData frm = new frmVehiclesData();
            frm.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            frm.Show();
        }

        private void dataOfCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriesData frm = new frmCategoriesData();
            frm.Show();
        }

        private void addNewTechnicalInspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTechnicalInspection frm = new frmAddTechnicalInspection();
            frm.Show();
        }

        private void dataOfTechnicalInspectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTechnicalInspectionData frm = new frmTechnicalInspectionData();
            frm.Show();
        }

        private void DrivingLicenceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TheoryTestApplicationsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheoryTestApplicationsData frm = new frmTheoryTestApplicationsData();
            frm.Show();
        }

        private void TheoryTestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheoryTestData frm = new frmTheoryTestData();
            frm.Show();
        }

        private void DrivingTestApplicationsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivingTestApplicationsData frm = new frmDrivingTestApplicationsData();
            frm.Show();
        }

        private void DrivingTestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivingTestData frm = new frmDrivingTestData();
            frm.Show();
        }

        private void DrivingLicencesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivingLicencesData frm = new frmDrivingLicencesData();
            frm.Show();
        }

        private void AddCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCertificate frm = new frmAddCertificate();
            frm.Show();
        }

        private void CertificateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCertificatesData frm = new frmCertificatesData();
            frm.Show();
        }

        private void CertificateRequestsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCertificatesRequestsData frm = new frmCertificatesRequestsData();
            frm.Show();
        }

        private void AddManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddManufacturer frm = new frmAddManufacturer();
            frm.Show();
        }

        /*
        private void UpdateCertificateRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCertificateRequest frm = new frmUpdateCertificateRequest();
            frm.Show();
        }*/
    }
}

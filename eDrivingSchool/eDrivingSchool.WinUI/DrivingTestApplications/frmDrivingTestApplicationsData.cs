using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.DrivingTestApplications
{
    public partial class frmDrivingTestApplicationsData : Form
    {
        private APIService _driving_test_applicationsService = new APIService("DrivingTestApplications");
        private APIService _categoriesService = new APIService("Categories");
        // private APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        public frmDrivingTestApplicationsData()
        {
            InitializeComponent();
        }

        private void DgvDrivingTestApplicationsData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvDrivingTestApplicationsData.SelectedRows[0].Cells[0].Value;
            frmDrivingTestApplicationsUpdate frm = new frmDrivingTestApplicationsUpdate(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            /*
            DrivingTestApplicationsSearchRequest search_request = new DrivingTestApplicationsSearchRequest();
            Model.Status status;
            if (Enum.TryParse(txtSearch.Text, out status))
            {
                search_request.Status = status;
            }*/

            DrivingTestApplicationsSearchRequest searchRequest = new DrivingTestApplicationsSearchRequest
            {
                Active = checkBoxActive.Checked
            };

            var result = await _driving_test_applicationsService.GetAll<List<Model.DrivingTestApplications>>(searchRequest);
            foreach (var driving_test_application in result)
            {
                driving_test_application.FirstName = driving_test_application.Instructor_Category_Candidate.Candidate.FirstName;
                driving_test_application.LastName = driving_test_application.Instructor_Category_Candidate.Candidate.LastName;
                driving_test_application.Username = driving_test_application.Instructor_Category_Candidate.Candidate.Username;
                var category = await _categoriesService.GetById<Model.Category>(driving_test_application.CategoryId);
                driving_test_application.Category = category.Name;
            }
            dgvDrivingTestApplicationsData.AutoGenerateColumns = false;
            dgvDrivingTestApplicationsData.DataSource = result;
        }

        private async void FrmDrivingTestApplicationsData_Load(object sender, EventArgs e)
        {
            /*
            DrivingTestApplicationsSearchRequest search_request = new DrivingTestApplicationsSearchRequest();
            search_request.Status = Model.Status.Inactive;
            var result = await _driving_test_applicationsService.GetAll<List<Model.DrivingTestApplications>>(search_request);
            foreach (var driving_test_application in result)
            {
                driving_test_application.FirstName = driving_test_application.Instructor_Category_Candidate.User.FirstName;
                driving_test_application.LastName = driving_test_application.Instructor_Category_Candidate.User.LastName;
                driving_test_application.Username = driving_test_application.Instructor_Category_Candidate.User.Username;
                var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(driving_test_application.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                driving_test_application.Category = category.Name;
            }
            dgvDrivingTestApplicationsData.AutoGenerateColumns = false;
            dgvDrivingTestApplicationsData.DataSource = result;*/
        }
    }
}

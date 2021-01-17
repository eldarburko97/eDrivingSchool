using eDrivingSchool.Model;
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

namespace eDrivingSchool.WinUI.DrivingTest
{
    public partial class frmDrivingTestData : Form
    {
        private APIService _driving_test_applicationsService = new APIService("DrivingTestApplications");
        private APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        private APIService _candidatesService = new APIService("Candidates");
        private APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        private APIService _categoriesService = new APIService("Categories");
        public frmDrivingTestData()
        {
            InitializeComponent();
        }

        private async void FrmDrivingTestData_Load(object sender, EventArgs e)
        {
            DrivingTestApplicationsSearchRequest search_request = new DrivingTestApplicationsSearchRequest();
            search_request.Status = Model.Status.Active;
            var result = await _driving_test_applicationsService.GetAll<List<Model.DrivingTestApplications>>(search_request);
            List<Instructor_Category_Candidate> list = new List<Instructor_Category_Candidate>();
            foreach (var item in result)
            {
                var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(item.Instructor_Category_CandidateId);
                var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.UserId);
                var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(instructor_category_candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                instructor_category_candidate.FirstName = candidate.FirstName;
                instructor_category_candidate.LastName = candidate.LastName;
                instructor_category_candidate.Username = candidate.Username;
                instructor_category_candidate.Category = category.Name;
                list.Add(instructor_category_candidate);
            }
            dgvDrivingTestData.AutoGenerateColumns = false;
            dgvDrivingTestData.DataSource = list;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            DrivingTestApplicationsSearchRequest search_request = new DrivingTestApplicationsSearchRequest();
            Model.Status status;
            if (Enum.TryParse(txtSearch.Text, out status))
            {
                search_request.Status = status;
            }
            var result = await _driving_test_applicationsService.GetAll<List<Model.DrivingTestApplications>>(search_request);
            List<Instructor_Category_Candidate> list = new List<Instructor_Category_Candidate>();
            foreach (var item in result)
            {
                var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(item.Instructor_Category_CandidateId);
                var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.UserId);
                var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(instructor_category_candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                instructor_category_candidate.FirstName = candidate.FirstName;
                instructor_category_candidate.LastName = candidate.LastName;
                instructor_category_candidate.Username = candidate.Username;
                instructor_category_candidate.Category = category.Name;
                list.Add(instructor_category_candidate);
            }
            dgvDrivingTestData.AutoGenerateColumns = false;
            dgvDrivingTestData.DataSource = list;
        }

        private void DgvDrivingTestData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvDrivingTestData.SelectedRows[0].Cells[0].Value;
            frmDrivingTestUpdate frm = new frmDrivingTestUpdate(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

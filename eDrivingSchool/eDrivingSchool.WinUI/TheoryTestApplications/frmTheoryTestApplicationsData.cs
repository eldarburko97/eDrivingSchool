using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.TheoryTestApplications
{
    public partial class frmTheoryTestApplicationsData : Form
    {
        private APIService _theory_test_applicationsService = new APIService("TheoryTestApplications");
        private APIService _categoriesService = new APIService("Categories");
        private APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        private InstructorCategoryCandidateAPIService InstructorCategoryCandidateAPIService = new InstructorCategoryCandidateAPIService("Instructors_Categories_Candidates");
        public frmTheoryTestApplicationsData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new TheoryTestApplicationsSearchRequest
            {
                //Status = (Model.Status)Enum.Parse(typeof(Model.Status), txtSearch.Text, true)
                Active = checkBoxActive.Checked,
               // Date = txtSearch.Text
            };
            DateTime date;
            if (DateTime.TryParseExact(txtSearch.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out date)) {
                search.Date = date.Date;
            };
            /*
            Model.Status status;
            if (Enum.TryParse(txtSearch.Text, out status))
            {
                search.Status = status;
            }*/

            var result = await _theory_test_applicationsService.GetAll<List<Model.TheoryTestApplications>>(search);
            dgvTheoryTestApplicationsData.AutoGenerateColumns = false;
            foreach (var theory_test_application in result)
            {
                theory_test_application.FirstName = theory_test_application.Instructor_Category_Candidate.Candidate.FirstName;
                theory_test_application.LastName = theory_test_application.Instructor_Category_Candidate.Candidate.LastName;
                theory_test_application.Username = theory_test_application.Instructor_Category_Candidate.Candidate.Username;
                var instructorId = theory_test_application.InstructorId;
                var categoryId = theory_test_application.CategoryId;
                var candidateId = theory_test_application.CandidateId;
                var InstructorCategoryCandidate = await InstructorCategoryCandidateAPIService.GetById<Model.Instructor_Category_Candidate>(instructorId,categoryId,candidateId);
                var category = await _categoriesService.GetById<Model.Category>(theory_test_application.CategoryId);
                theory_test_application.Category = category.Name;
              //  theory_test_application.TheoryTest = !InstructorCategoryCandidate.PolozenTeorijskiTest;
               // theory_test_application.FirstAid = !InstructorCategoryCandidate.PolozenTestPrvePomoci;
            }
            dgvTheoryTestApplicationsData.AutoGenerateColumns = false;
            dgvTheoryTestApplicationsData.DataSource = result;
        }

        private void DgvTheoryTestApplicationsData_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var id = dgvTheoryTestApplicationsData.SelectedRows[0].Cells[0].Value;
            frmTheoryTestApplicationsUpdate frm = new frmTheoryTestApplicationsUpdate(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void FrmTheoryTestApplicationsData_Load(object sender, EventArgs e)
        {
            /*
            TheoryTestApplicationsSearchRequest search_request = new TheoryTestApplicationsSearchRequest();
            search_request.Status = Model.Status.Inactive;
            var result = await _theory_test_applicationsService.GetAll<List<Model.TheoryTestApplications>>(search_request);
            foreach (var theory_test_application in result)
            {
              //  theory_test_application.FirstName = theory_test_application.Instructor_Category_Candidate.User.FirstName;
               // theory_test_application.LastName = theory_test_application.Instructor_Category_Candidate.User.LastName;
              //  theory_test_application.Username = theory_test_application.Instructor_Category_Candidate.User.Username;
               // var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(theory_test_application.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(theory_test_application.CategoryId);
                theory_test_application.Category = category.Name;
            }
            dgvTheoryTestApplicationsData.AutoGenerateColumns = false;
            dgvTheoryTestApplicationsData.DataSource = result;*/
        }
    }
}

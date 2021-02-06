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
    public partial class frmDrivingTestApplicationsUpdate : Form
    {
        private APIService _driving_test_applicationsService = new APIService("DrivingTestApplications");
        private InstructorCategoryCandidateAPIService _instructor_categories_candidatesService = new InstructorCategoryCandidateAPIService("Instructors_Categories_Candidates");
        private APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private APIService _categoriesService = new APIService("Categories");
        private int? _id = null;
        public frmDrivingTestApplicationsUpdate(int? id = null)
        {
            InitializeComponent();
            // InitializecmbStatuses();
            _id = id;
        }

        private void InitializecmbStatuses()
        {
            cmbStatuses.Items.AddRange(Enum.GetNames(typeof(Model.Status)));
        }

        private async void FrmDrivingTestApplicationsUpdate_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var _driving_test_application = await _driving_test_applicationsService.GetById<Model.DrivingTestApplications>(_id);
                //var instructor_category_candidate = await _instructor_categories_candidatesService.get
                txtFirstName.Text = _driving_test_application.Instructor_Category_Candidate.Candidate.FirstName;
                txtLastName.Text = _driving_test_application.Instructor_Category_Candidate.Candidate.LastName;
                txtUsername.Text = _driving_test_application.Instructor_Category_Candidate.Candidate.Username;
                var category = await _categoriesService.GetById<Model.Category>(_driving_test_application.CategoryId);
                txtCategory.Text = category.Name;
                txtDate.Text = _driving_test_application.Date.Date.ToString("MM/dd/yyyy");
                checkBoxPolozenPrakticniTest.Checked = _driving_test_application.Passed;
                checkBoxActive.Checked = _driving_test_application.Active;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var _driving_test_application = await _driving_test_applicationsService.GetById<Model.DrivingTestApplications>(_id);
            DrivingTestApplicationsInsertRequest insertRequest = new DrivingTestApplicationsInsertRequest
            {
                InstructorId = _driving_test_application.InstructorId,
                CategoryId = _driving_test_application.CategoryId,
                CandidateId = _driving_test_application.CandidateId,
                Date = _driving_test_application.Date.Date,
                Active = checkBoxActive.Checked == true ? true : false,
                Passed = checkBoxPolozenPrakticniTest.Checked,
            };
            await _driving_test_applicationsService.Update<Model.DrivingTestApplications>(_id, insertRequest);
            var instructorId = _driving_test_application.InstructorId;
            var categoryId = _driving_test_application.CategoryId;
            var candidateId = _driving_test_application.CandidateId;
            var instructor_Category_Candidate = await _instructor_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(instructorId, categoryId, candidateId);
            InstructorCategoryCandidateInsertRequest instructorCategoryCandidateInsertRequest = new InstructorCategoryCandidateInsertRequest
            {
                PolozenTeorijskiTest = instructor_Category_Candidate.PolozenTeorijskiTest,
                PolozenTestPrvePomoci = instructor_Category_Candidate.PolozenTestPrvePomoci,
                PolozenPrakticniTest = checkBoxPolozenPrakticniTest.Checked,
                Prijavljen = checkBoxActive.Checked == true ? true : false,
                NumberOfLessons = instructor_Category_Candidate.NumberOfLessons,
                Paid = instructor_Category_Candidate.Paid,
                Date = (instructor_Category_Candidate.Date != null) ? (DateTime?)instructor_Category_Candidate.Date.Value : null,
            };
            await _instructor_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(instructorId, categoryId, candidateId, instructorCategoryCandidateInsertRequest);          
        }
    }
}

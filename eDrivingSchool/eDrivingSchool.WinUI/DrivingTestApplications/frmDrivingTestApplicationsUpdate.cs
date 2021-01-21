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
        private APIService _instructor_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        private APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private APIService _categoriesService = new APIService("Categories");
        private int? _id = null;
        public frmDrivingTestApplicationsUpdate(int? id = null)
        {
            InitializeComponent();
            InitializecmbStatuses();
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
                txtFirstName.Text = _driving_test_application.Instructor_Category_Candidate.User.FirstName;
                txtLastName.Text = _driving_test_application.Instructor_Category_Candidate.User.LastName;
                txtUsername.Text = _driving_test_application.Instructor_Category_Candidate.User.Username;
                var instructor_category = await _instructor_categoriesService.GetById<Model.Instructor_Category>(_driving_test_application.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                txtCategory.Text = category.Name;
                // dtpDate.Value = _driving_test_application.Date;
                txtDate.Text = _driving_test_application.Date.Date.ToString("MM/dd/yyyy");
                // txtStatus.Text = _driving_test_application.Status.ToString();
                cmbStatuses.SelectedIndex = (int)_driving_test_application.Status;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var _driving_test_application = await _driving_test_applicationsService.GetById<Model.DrivingTestApplications>(_id);
            DrivingTestApplicationsInsertRequest insert_request = new DrivingTestApplicationsInsertRequest();
            insert_request.Instructor_Category_CandidateId = _driving_test_application.Instructor_Category_CandidateId;
            insert_request.Date = _driving_test_application.Date.Date;
            /* Model.Status status;
             if (Enum.TryParse(txtStatus.Text, out status))
             {
                 insert_request.Status = status;
             }*/
            insert_request.Status = (Model.Status)cmbStatuses.SelectedIndex;
            insert_request.Passed = _driving_test_application.Passed;
            if (_id.HasValue)
            {
                var updated = await _driving_test_applicationsService.Update<Model.DrivingTestApplications>(_id, insert_request);
                if (updated.Status == Model.Status.Expired)
                {
                    var instructor_category_candidate = await _instructor_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(updated.Instructor_Category_CandidateId);
                    InstructorCategoryCandidateInsertRequest instructorCategoryCandidateInsertRequest = new InstructorCategoryCandidateInsertRequest
                    {
                        Instructor_CategoryId = instructor_category_candidate.Instructor_CategoryId,
                        UserId = instructor_category_candidate.UserId,
                        Prijavljen = false,
                        PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest,
                        PolozenTeorijskiTest = instructor_category_candidate.PolozenTeorijskiTest,
                        PolozenTestPrvePomoci = instructor_category_candidate.PolozenTestPrvePomoci,
                        NumberOfLessons = instructor_category_candidate.NumberOfLessons,
                        Paid = instructor_category_candidate.Paid
                    };
                    await _instructor_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(updated.Instructor_Category_CandidateId, instructorCategoryCandidateInsertRequest);
                }
            }
        }
    }
}

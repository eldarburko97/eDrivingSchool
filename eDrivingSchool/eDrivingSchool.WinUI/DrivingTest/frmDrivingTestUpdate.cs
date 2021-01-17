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
    public partial class frmDrivingTestUpdate : Form
    {
        APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        APIService _candidatesService = new APIService("Candidates");
        APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        APIService _categoriesService = new APIService("Categories");
        APIService _driving_test_applicationsService = new APIService("DrivingTestApplications");
        private int? _id = null;
        public frmDrivingTestUpdate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmDrivingTestUpdate_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(_id);
                var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.UserId);
                var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(instructor_category_candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);

                txtFirstName.Text = candidate.FirstName;
                txtLastName.Text = candidate.LastName;
                txtUsername.Text = candidate.Username;
                txtCategory.Text = category.Name;
                checkBoxPolozenPrakticniTest.Checked = instructor_category_candidate.PolozenPrakticniTest;
                checkBoxPrijavljen.Checked = instructor_category_candidate.Prijavljen;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(_id);
            InstructorCategoryCandidateInsertRequest update_request = new InstructorCategoryCandidateInsertRequest
            {
                Instructor_CategoryId = instructor_category_candidate.Instructor_CategoryId,
                UserId = instructor_category_candidate.UserId,
                PolozenTestPrvePomoci = instructor_category_candidate.PolozenTestPrvePomoci,
                PolozenTeorijskiTest = instructor_category_candidate.PolozenTeorijskiTest,
                PolozenPrakticniTest = checkBoxPolozenPrakticniTest.Checked,
                Prijavljen = checkBoxPrijavljen.Checked,
                NumberOfLessons = instructor_category_candidate.NumberOfLessons,
                Paid = instructor_category_candidate.Paid
            };
            var updated = await _instructors_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(_id, update_request);
            DrivingTestApplicationsSearchRequest search_request = new DrivingTestApplicationsSearchRequest
            {
                Instructor_Category_CandidateId = instructor_category_candidate.Id,
                Status = Model.Status.Active
            };
            var list = await _driving_test_applicationsService.GetAll<List<Model.DrivingTestApplications>>(search_request);
            DrivingTestApplicationsInsertRequest update_request2 = new DrivingTestApplicationsInsertRequest();
            foreach (var item in list)
            {
                update_request2.Instructor_Category_CandidateId = item.Instructor_Category_CandidateId;
                update_request2.Date = item.Date;
                update_request2.Passed = updated.PolozenPrakticniTest;
                update_request2.Status = Model.Status.Expired;
                await _driving_test_applicationsService.Update<Model.DrivingTestApplications>(item.Id, update_request2);
            }
        }
    }
}

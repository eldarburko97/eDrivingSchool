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

namespace eDrivingSchool.WinUI.TheoryTestApplications
{
    public partial class frmTheoryTestApplicationsUpdate : Form
    {
        private APIService _theory_test_applicationsService = new APIService("TheoryTestApplications");
        private APIService _instructor_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        private int? _id = null;
        public frmTheoryTestApplicationsUpdate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmTheoryTestApplicationsUpdate_Load(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var _theory_test_application = await _theory_test_applicationsService.GetById<Model.TheoryTestApplications>(_id);
                txtFirstName.Text = _theory_test_application.Instructor_Category_Candidate.User.FirstName;
                txtLastName.Text = _theory_test_application.Instructor_Category_Candidate.User.LastName;
                dtpDate.Value = _theory_test_application.Date;
                txtStatus.Text = _theory_test_application.Status.ToString();
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var _theory_test_application = await _theory_test_applicationsService.GetById<Model.TheoryTestApplications>(_id);
            TheoryTestApplicationsInsertRequest insert_request = new TheoryTestApplicationsInsertRequest();
            insert_request.Instructor_Category_CandidateId = _theory_test_application.Instructor_Category_CandidateId;
            insert_request.Date = _theory_test_application.Date;
            Model.Status status;
            if (Enum.TryParse(txtStatus.Text, out status))
            {
                insert_request.Status = status;
            }

            if (_id.HasValue)
            {
                var updated = await _theory_test_applicationsService.Update<Model.TheoryTestApplications>(_id, insert_request);
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

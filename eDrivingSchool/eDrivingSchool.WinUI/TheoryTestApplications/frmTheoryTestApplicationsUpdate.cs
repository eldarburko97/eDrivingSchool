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
        private InstructorCategoryCandidateAPIService _instructor_categories_candidatesService = new InstructorCategoryCandidateAPIService("Instructors_Categories_Candidates");
        private APIService _categoriesService = new APIService("Categories");
        private APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        private int? _id = null;
        public frmTheoryTestApplicationsUpdate(int? id = null)
        {
            InitializeComponent();
         //   InitializecmbStatuses();
            this.AutoValidate = AutoValidate.Disable;
            _id = id;
        }

        private void InitializecmbStatuses()
        {
            cmbStatuses.Items.AddRange(Enum.GetNames(typeof(Model.Status)));
        }

        private async void FrmTheoryTestApplicationsUpdate_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var _theory_test_application = await _theory_test_applicationsService.GetById<Model.TheoryTestApplications>(_id);
                //  txtFirstName.Text = _theory_test_application.Instructor_Category_Candidate.User.FirstName;
                // txtLastName.Text = _theory_test_application.Instructor_Category_Candidate.User.LastName;
                // txtUsername.Text = _theory_test_application.Instructor_Category_Candidate.User.Username;

                var instructor_category_candidate = await _instructor_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(_theory_test_application.InstructorId, _theory_test_application.CategoryId, _theory_test_application.CandidateId);

                txtFirstName.Text = _theory_test_application.Instructor_Category_Candidate.Candidate.FirstName;
                txtLastName.Text = _theory_test_application.Instructor_Category_Candidate.Candidate.LastName;
                txtUsername.Text = _theory_test_application.Instructor_Category_Candidate.Candidate.Username;
                // var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(_theory_test_application.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(_theory_test_application.CategoryId);
                txtCategory.Text = category.Name;
                //txtStatus.Text = _theory_test_application.Status.ToString();
                txtDate.Text = _theory_test_application.Date.Date.ToString("MM/dd/yyyy");
                // cmbStatuses.SelectedIndex = (int)_theory_test_application.Status;
                // checkBoxPrijavljen.Checked = instructor_category_candidate.Prijavljen;
                // checkBoxPolozenTeorijskiIspit.Checked = _theory_test_application.PolozenTeorijskiTest;
                // checkBoxPolozenTestPrvePomoci.Checked = _theory_test_application.PolozenTestPrvePomoci;
                checkBoxPolozenTeorijskiIspit.Checked = instructor_category_candidate.PolozenTeorijskiTest;
                checkBoxPolozenTestPrvePomoci.Checked = instructor_category_candidate.PolozenTestPrvePomoci;
                checkBoxActive.Checked = _theory_test_application.Active;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (_id.HasValue)
                {
                    var _theory_test_application = await _theory_test_applicationsService.GetById<Model.TheoryTestApplications>(_id);
                    var instructor_category_candidate = await _instructor_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(_theory_test_application.InstructorId, _theory_test_application.CategoryId, _theory_test_application.CandidateId);
                    var instructorId = instructor_category_candidate.InstructorId;
                    var categoryId = instructor_category_candidate.CategoryId;
                    var candidateId = instructor_category_candidate.CandidateId;
                    InstructorCategoryCandidateInsertRequest updateRequest = new InstructorCategoryCandidateInsertRequest
                    {
                        PolozenTeorijskiTest = checkBoxPolozenTeorijskiIspit.Checked,
                        PolozenTestPrvePomoci = checkBoxPolozenTestPrvePomoci.Checked,
                        PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest,
                        Prijavljen = checkBoxActive.Checked == true ? true : false,
                        NumberOfLessons = instructor_category_candidate.NumberOfLessons,
                        Paid = instructor_category_candidate.Paid,
                        Date = (instructor_category_candidate.Date != null) ? (DateTime?)instructor_category_candidate.Date.Value : null,
                    };
                    await _instructor_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(instructorId, categoryId, candidateId, updateRequest);
                    TheoryTestApplicationsInsertRequest updateRequest2 = new TheoryTestApplicationsInsertRequest
                    {
                        InstructorId = _theory_test_application.InstructorId,
                        CategoryId = _theory_test_application.CategoryId,
                        CandidateId = _theory_test_application.CandidateId,
                        Active = checkBoxActive.Checked == true ? true : false,
                        Date = _theory_test_application.Date.Date,
                        // TheoryTest = !checkBoxPolozenTeorijskiIspit.Checked,
                        // FirstAid = !checkBoxPolozenTestPrvePomoci.Checked,
                        TheoryTest = _theory_test_application.TheoryTest,
                        FirstAid = _theory_test_application.FirstAid
                    };
                    await _theory_test_applicationsService.Update<Model.TheoryTestApplications>(_id, updateRequest2);

                    /*
                    var _theory_test_application = await _theory_test_applicationsService.GetById<Model.TheoryTestApplications>(_id);
                    TheoryTestApplicationsInsertRequest insert_request = new TheoryTestApplicationsInsertRequest();
                    insert_request.InstructorId = _theory_test_application.InstructorId;
                    insert_request.CategoryId = _theory_test_application.CategoryId;
                    insert_request.CandidateId = _theory_test_application.CandidateId;
                    insert_request.Date = _theory_test_application.Date.Date;
                       Model.Status status;
                       if (Enum.TryParse(txtStatus.Text, out status))
                       {
                           insert_request.Status = status;
                       }
                    insert_request.Status = (Model.Status)cmbStatuses.SelectedIndex;
                    insert_request.FirstAid = _theory_test_application.FirstAid;
                    insert_request.TheoryTest = _theory_test_application.TheoryTest;

                    var updated = await _theory_test_applicationsService.Update<Model.TheoryTestApplications>(_id, insert_request);
                    if (updated.Status == Model.Status.Expired)
                    {
                        var instructor_category_candidate = await _instructor_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(updated.InstructorId, updated.CategoryId, updated.CandidateId);
                        InstructorCategoryCandidateInsertRequest instructorCategoryCandidateInsertRequest = new InstructorCategoryCandidateInsertRequest
                        {
                            //  Instructor_CategoryId = instructor_category_candidate.Instructor_CategoryId,
                            //   UserId = instructor_category_candidate.UserId,
                            Prijavljen = false,
                            PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest,
                            PolozenTeorijskiTest = instructor_category_candidate.PolozenTeorijskiTest,
                            PolozenTestPrvePomoci = instructor_category_candidate.PolozenTestPrvePomoci,
                            NumberOfLessons = instructor_category_candidate.NumberOfLessons,
                            Paid = instructor_category_candidate.Paid
                        };
                        await _instructor_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(updated.InstructorId, updated.CategoryId, updated.CandidateId, instructorCategoryCandidateInsertRequest);
                    }*/
                }
            }
        }

        /*
        private void TxtStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStatus, Messages.Validation_Field_Required);
            }
        }*/
    }
}

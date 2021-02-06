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

namespace eDrivingSchool.WinUI.Driving_Licences
{
    public partial class frmDrivingLicencesUpdate : Form
    {
        APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        APIService _candidatesService = new APIService("Candidates");
        APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        APIService _categoriesService = new APIService("Categories");
        private int? _id = null;
        public frmDrivingLicencesUpdate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmDrivingLicencesUpdate_Load(object sender, EventArgs e)
        {
            /*
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
                txtNumberOfLessons.Text = instructor_category_candidate.NumberOfLessons.ToString();
                checkBoxPaid.Checked = instructor_category_candidate.Paid;
                dtpDate.Value = instructor_category_candidate.Date == null ? DateTime.Now.Date : instructor_category_candidate.Date.Value.Date;
            }*/
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            /*
            var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(_id);
            InstructorCategoryCandidateInsertRequest update_request = new InstructorCategoryCandidateInsertRequest
            {
                Instructor_CategoryId = instructor_category_candidate.Instructor_CategoryId,
                UserId = instructor_category_candidate.UserId,
                PolozenTestPrvePomoci = instructor_category_candidate.PolozenTestPrvePomoci,
                PolozenTeorijskiTest = instructor_category_candidate.PolozenTeorijskiTest,
                PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest,
                Prijavljen =instructor_category_candidate.Prijavljen,
                NumberOfLessons = instructor_category_candidate.NumberOfLessons,
                Paid = checkBoxPaid.Checked,
                Date = dtpDate.Value.Date,
            };
            var updated = await _instructors_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(_id, update_request);*/
        }
    }
}

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

namespace eDrivingSchool.WinUI.TheoryTest
{
    public partial class frmTheoryTestUpdate : Form
    {
        APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        APIService _candidatesService = new APIService("Candidates");
        APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        APIService _categoriesService = new APIService("Categories");
        private int? _id = null;
        public frmTheoryTestUpdate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmTheoryTestUpdate_Load(object sender, EventArgs e)
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
                checkBoxPolozenTeorijskiIspit.Checked = instructor_category_candidate.PolozenTeorijskiTest;
                checkBoxPolozenTestPrvePomoci.Checked = instructor_category_candidate.PolozenTestPrvePomoci;
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
                PolozenTestPrvePomoci = checkBoxPolozenTestPrvePomoci.Checked,
                PolozenTeorijskiTest = checkBoxPolozenTeorijskiIspit.Checked,
                PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest,
                Prijavljen = checkBoxPrijavljen.Checked,
                NumberOfLessons = instructor_category_candidate.NumberOfLessons,
                Paid = instructor_category_candidate.Paid
            };
            await _instructors_categories_candidatesService.Update<Model.Instructor_Category_Candidate>(_id, update_request);
        }
    }
}

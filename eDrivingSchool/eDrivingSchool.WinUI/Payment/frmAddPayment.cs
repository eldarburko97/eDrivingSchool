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

namespace eDrivingSchool.WinUI.Payment
{
    public partial class frmAddPayment : Form
    {
        private int? _id = null;
        PaymentInsertRequest insertRequest = new PaymentInsertRequest();
        APIService _apiService = new APIService("Payments");
        APIService _candidatesService = new APIService("Candidates");
        InstructorCategoryCandidateAPIService _instructors_categories_candidatesService = new InstructorCategoryCandidateAPIService("Instructors_Categories_Candidates");
        APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        APIService _categoriesService = new APIService("Categories");
        InstructorCategoryCandidateSearchRequest search_request = new InstructorCategoryCandidateSearchRequest();
        public frmAddPayment(int? id = null)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            _id = id;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                /*
                var idObj = cmbCandidate.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int CandidateId))
                {
                    //  insert_request.UserId = CandidateId;
                    insert_request.Instructor_Category_CandidateId = CandidateId;
                }
              //  insert_request.Category = txtCategory.Text;
                insert_request.Amount = float.Parse(txtAmount.Text);
                insert_request.DateOfPayment = dtpDateOfPayment.Value.Date;
                insert_request.Note = txtNote.Text;
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Payment>(_id, insert_request);
                }
                else
                {
                    await _apiService.Insert<Model.Payment>(insert_request);
                    MessageBox.Show("Payment successfully added!");
                }*/
                var InstructorCategoryCandidate = cmbCandidate.SelectedItem as Model.Instructor_Category_Candidate;
                insertRequest.InstructorId = InstructorCategoryCandidate.InstructorId;
                insertRequest.CategoryId = InstructorCategoryCandidate.CategoryId;
                insertRequest.CandidateId = InstructorCategoryCandidate.CandidateId;
                insertRequest.Amount = float.Parse(txtAmount.Text);
                insertRequest.DateOfPayment = dtpDateOfPayment.Value.Date.Date;
                insertRequest.Note = txtNote.Text;
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Payment>(_id, insertRequest);
                    MessageBox.Show("Payment successfully updated !", " ", MessageBoxButtons.OK);
                }
                else
                {
                    await _apiService.Insert<Model.Payment>(insertRequest);
                    MessageBox.Show("Payment successfully added !", " ", MessageBoxButtons.OK);
                }
            }
        }

        private async void FrmAddPayment_Load(object sender, EventArgs e)
        {
            await LoadCandidates();
            if (_id.HasValue)
            {
                var payment = await _apiService.GetById<Model.Payment>(_id);
                txtAmount.Text = payment.Amount.ToString();
                //txtCategory.Text = payment.Category;
                txtNote.Text = payment.Note;
                dtpDateOfPayment.Value = payment.DateOfPayment.Date;
            }
        }
        private async Task LoadCandidates()
        {
            if (_id.HasValue)
            {
                var payment = await _apiService.GetById<Model.Payment>(_id);
                //  var candidate = await _candidatesService.GetById<Model.Candidate>(payment.UserId);
                //  candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + payment.Category + ")";
                /*  var candidates = await _candidatesService.GetAll<List<Model.Candidate>>(null);
                  foreach (var item in candidates)
                  {
                      item.candidate_category = item.FirstName + " " + item.LastName + " " + "(" + payment.Category + ")";
                  }*/
                /*
              search_request.Paid = false;
              var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(payment.Instructor_Category_CandidateId);
              var instructors_categories_candidates = await _instructors_categories_candidatesService.GetAll<List<Model.Instructor_Category_Candidate>>(search_request);
              foreach (var item in instructors_categories_candidates)
              {
                  var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(item.Instructor_CategoryId);
                  var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                  item.candidate_category = item.User.FirstName + " " + item.User.LastName + " " + "(" + category.Name + ")";
              }

              cmbCandidate.DisplayMember = "candidate_category";
              cmbCandidate.ValueMember = "Id";
              cmbCandidate.DataSource = instructors_categories_candidates;
              cmbCandidate.SelectedValue = instructor_category_candidate.Id;*/
                var instructors_categories_candidates = await _instructors_categories_candidatesService.GetAll<List<Model.Instructor_Category_Candidate>>(search_request);
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.CandidateId);
                    instructor_category_candidate.FirstName = candidate.FirstName;
                    instructor_category_candidate.LastName = candidate.LastName;
                    instructor_category_candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + instructor_category_candidate.Instructor_Category.Category.Name + ")";
                }
                var InstructorCategoryCandidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(payment.InstructorId, payment.CategoryId, payment.CandidateId);
                InstructorCategoryCandidate.FirstName = InstructorCategoryCandidate.Candidate.FirstName;
                InstructorCategoryCandidate.LastName = InstructorCategoryCandidate.Candidate.LastName;
                var category = await _categoriesService.GetById<Model.Category>(InstructorCategoryCandidate.CategoryId);
                InstructorCategoryCandidate.Category = category.Name;
                int index = 0;
                for (int i = 0; i < instructors_categories_candidates.Count; i++)
                {
                    cmbCandidate.Items.Add(instructors_categories_candidates[i]);
                    if (instructors_categories_candidates[i].InstructorId == InstructorCategoryCandidate.InstructorId && instructors_categories_candidates[i].CategoryId == InstructorCategoryCandidate.CategoryId && instructors_categories_candidates[i].CandidateId == InstructorCategoryCandidate.CandidateId)
                    {
                        index = i;
                    }
                }
                cmbCandidate.DisplayMember = "candidate_category";
                cmbCandidate.SelectedIndex = index;
            }
            else
            {
                search_request.Paid = false;
                var instructors_categories_candidates = await _instructors_categories_candidatesService.GetAll<List<Model.Instructor_Category_Candidate>>(search_request);
                //List<Model.Candidate> candidates = new List<Model.Candidate>();
                // candidates.Insert(0, new Model.Candidate());
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    //  var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.UserId);
                    //  var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(instructor_category_candidate.Instructor_CategoryId);
                    //  var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                    // instructor_category_candidate.candidate_category = instructor_category_candidate.User.FirstName + " " + instructor_category_candidate.User.LastName + " " + "(" + category.Name + ")";
                    //  candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + category.Name + ")";
                    //  candidates.Add(candidate);
                    var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.CandidateId);
                    instructor_category_candidate.FirstName = candidate.FirstName;
                    instructor_category_candidate.LastName = candidate.LastName;
                    //  instructor_category_candidate.Category = instructor_category_candidate.Instructor_Category.Category.Name;
                    instructor_category_candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + instructor_category_candidate.Instructor_Category.Category.Name + ")";
                }
                /*
                cmbCandidate.DisplayMember = "candidate_category";
                cmbCandidate.ValueMember = "Id";
                cmbCandidate.DataSource = candidates;*/
                instructors_categories_candidates.Insert(0, new Model.Instructor_Category_Candidate());
                foreach (var item in instructors_categories_candidates)
                {
                    cmbCandidate.Items.Add(item);
                }
                cmbCandidate.DisplayMember = "candidate_category";
                // cmbCandidate.ValueMember = "Id";
                // cmbCandidate.DataSource = instructors_categories_candidates;
            }
        }

        /*
        private void TxtCategory_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCategory, Messages.Validation_Field_Required);
            }
        }*/

        private void TxtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAmount, Messages.Validation_Field_Required);
            }
            else
            {
                try
                {
                    float amount = float.Parse(txtAmount.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtAmount, Messages.amount_err);
                }
            }
        }

        private void TxtNote_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNote, Messages.Validation_Field_Required);
            }
        }

        private void CmbCandidate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCandidate.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbCandidate, Messages.Validation_Field_Required);
            }
        }
    }
}

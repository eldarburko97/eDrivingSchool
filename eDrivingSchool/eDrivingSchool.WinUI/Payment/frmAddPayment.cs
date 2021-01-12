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
        PaymentInsertRequest insert_request = new PaymentInsertRequest();
        APIService _apiService = new APIService("Payments");
        APIService _candidatesService = new APIService("Candidates");
        APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        APIService _categoriesService = new APIService("Categories");
        InstructorCategoryCandidateSearchRequest search_request = new InstructorCategoryCandidateSearchRequest();
        public frmAddPayment(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var idObj = cmbCandidate.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int CandidateId))
            {
                insert_request.UserId = CandidateId;
            }
            insert_request.Category = txtCategory.Text;
            insert_request.Amount = float.Parse(txtAmount.Text);
            insert_request.DateOfPayment = dtpDateOfPayment.Value;
            insert_request.Note = txtNote.Text;
            if (_id.HasValue)
            {
                await _apiService.Update<Model.Payment>(_id, insert_request);
            }
            else
            {
                await _apiService.Insert<Model.Payment>(insert_request);
            }
        }

        private async void FrmAddPayment_Load(object sender, EventArgs e)
        {
          
            await LoadKandidati();
            if (_id.HasValue)
            {
                var payment = await _apiService.GetById<Model.Payment>(_id);
                txtAmount.Text = payment.Amount.ToString();
                txtCategory.Text = payment.Category;
                txtNote.Text = payment.Note;
            }
        }
        private async Task LoadKandidati()
        {
            if (_id.HasValue)
            {
                var payment = await _apiService.GetById<Model.Payment>(_id);
                var candidate = await _candidatesService.GetById<Model.Candidate>(payment.UserId);
                candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + payment.Category + ")";
                var candidates = await _candidatesService.GetAll<List<Model.Candidate>>(null);
                foreach (var item in candidates)
                {
                    item.candidate_category = item.FirstName + " " + item.LastName + " " + "(" + payment.Category + ")";
                }

                cmbCandidate.DisplayMember = "candidate_category";
                cmbCandidate.ValueMember = "Id";
                cmbCandidate.DataSource = candidates;
                cmbCandidate.SelectedValue = candidate.Id;
               
            }
            else
            {
                search_request.Paid = false;
                var instructors_categories_candidates = await _instructors_categories_candidatesService.GetAll<List<Model.Instructor_Category_Candidate>>(search_request);
                List<Model.Candidate> candidates = new List<Model.Candidate>();
                candidates.Insert(0, new Model.Candidate());
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.UserId);
                    var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(instructor_category_candidate.Instructor_CategoryId);
                    var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                    candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + category.Name + ")";
                    candidates.Add(candidate);
                }
                cmbCandidate.DisplayMember = "candidate_category";
                cmbCandidate.ValueMember = "Id";
                cmbCandidate.DataSource = candidates;
            }
        }
    }
}

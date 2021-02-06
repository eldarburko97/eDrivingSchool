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
    public partial class frmPaymentData : Form
    {
        private APIService _apiService = new APIService("Payments");
        private APIService _instructor_categoryService = new APIService("Instructors_Categories");
        private APIService _categoryService = new APIService("Categories");
        private APIService candidateService = new APIService("Candidates");
        public frmPaymentData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {      /*      
            var search2 = new CandidateSearchRequest
            {
                Username = txtSearch.Text
            };
            var candidates = await candidateService.GetAll<List<Model.Candidate>>(search2);
            if(candidates.Count > 0)
            {
                var candidate = candidates[0];
            }
            
            var search = new PaymentSearchRequest
            {
                //  Category = txtSearch.Text
                CandidateId = 
            };*/
            
            var result = await _apiService.GetAll<List<Model.Payment>>(null);
            foreach (var payment in result)
            {
                payment.FirstName = payment.Instructor_Category_Candidate.Candidate.FirstName;
                payment.LastName = payment.Instructor_Category_Candidate.Candidate.LastName;
               // var instructor_category = await _instructor_categoryService.GetById<Model.Instructor_Category>(payment.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoryService.GetById<Model.Category>(payment.CategoryId);
                payment.Category = category.Name;
            }
            dgvPaymentsData.AutoGenerateColumns = false;
            dgvPaymentsData.DataSource = result;
        }

        private void DgvPaymentsData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPaymentsData.SelectedRows[0].Cells[0].Value;
            frmAddPayment frm = new frmAddPayment(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

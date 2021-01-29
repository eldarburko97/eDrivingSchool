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
        public frmPaymentData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new PaymentSearchRequest
            {
                Category = txtSearch.Text
            };
            var result = await _apiService.GetAll<List<Model.Payment>>(search);
            foreach (var payment in result)
            {
                payment.FirstName = payment.Instructor_Category_Candidate.User.FirstName;
                payment.LastName = payment.Instructor_Category_Candidate.User.LastName;
                var instructor_category = await _instructor_categoryService.GetById<Model.Instructor_Category>(payment.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoryService.GetById<Model.Category>(instructor_category.CategoryId);
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

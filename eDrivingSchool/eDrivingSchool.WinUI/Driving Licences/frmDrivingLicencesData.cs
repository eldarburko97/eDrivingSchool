using eDrivingSchool.Model;
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
    public partial class frmDrivingLicencesData : Form
    {
        private APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        private APIService _candidateService = new APIService("Candidates");
        private APIService _paymentService = new APIService("Payments");
        public frmDrivingLicencesData()
        {
            InitializeComponent();
        }

        private void DgvDrivingLicencesData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvDrivingLicencesData.SelectedRows[0].Cells[0].Value;
            frmDrivingLicencesUpdate frm = new frmDrivingLicencesUpdate(int.Parse(id.ToString()));
            frm.Show();
        }
        /*
        private async void FrmDrivingLicencesData_Load(object sender, EventArgs e)
        {
            InstructorCategoryCandidateSearchRequest search_request = new InstructorCategoryCandidateSearchRequest
            {
                PolozenPrakticniTest = true,
                Prijavljen = false,
            };
            var result = await _instructors_categories_candidatesService.GetAll<List<Instructor_Category_Candidate>>(search_request);
            foreach (var item in result)
            {
                var candidate = await _candidateService.GetById<Model.Candidate>(item.UserId);
                item.FirstName = candidate.FirstName;
                item.LastName = candidate.LastName;
                item.Username = candidate.Username;
                item.Category = item.Instructor_Category.Category.Name;
            }
            dgvDrivingLicencesData.AutoGenerateColumns = false;
            dgvDrivingLicencesData.DataSource = result;

        }*/

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            bool validValue;
            DateTime validValue2;
            InstructorCategoryCandidateSearchRequest search_request = new InstructorCategoryCandidateSearchRequest
            {
                PolozenPrakticniTest = true,
                Prijavljen = false,
                Paid = Boolean.TryParse(txtSearch.Text, out validValue) ? validValue : false,
                Date = DateTime.TryParse(txtSearch.Text, out validValue2) ? validValue2 : (DateTime?)null
            };
            PaymentSearchRequest search_request2 = new PaymentSearchRequest();
            var result = await _instructors_categories_candidatesService.GetAll<List<Instructor_Category_Candidate>>(search_request);
            foreach (var item in result)
            {
                var candidate = await _candidateService.GetById<Model.Candidate>(item.UserId);
                item.FirstName = candidate.FirstName;
                item.LastName = candidate.LastName;
                item.Username = candidate.Username;
                item.Category = item.Instructor_Category.Category.Name;
                search_request2.UserId = item.UserId;
                var payments = await _paymentService.GetAll<List<Model.Payment>>(search_request2);
                foreach (var payment in payments)
                {
                   if(item.Instructor_Category.Category.Name == payment.Category)
                    {
                        item.Uplatio += payment.Amount;
                    }
                }
                item.Duzan = (item.NumberOfLessons * 20) - item.Uplatio;
            }
            dgvDrivingLicencesData.AutoGenerateColumns = false;
            dgvDrivingLicencesData.DataSource = result;
        }
    }
}

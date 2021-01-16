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
    public partial class frmTheoryTestApplicationsData : Form
    {
        private APIService _theory_test_applicationsService = new APIService("TheoryTestApplications");
        private APIService _categoriesService = new APIService("Categories");
        private APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        public frmTheoryTestApplicationsData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new TheoryTestApplicationsSearchRequest
            {
                //Status = (Model.Status)Enum.Parse(typeof(Model.Status), txtSearch.Text, true)

            };
            Model.Status status;
            if (Enum.TryParse(txtSearch.Text, out status))
            {
                search.Status = status;
            }

            var result = await _theory_test_applicationsService.GetAll<List<Model.TheoryTestApplications>>(search);
            dgvTheoryTestApplicationsData.AutoGenerateColumns = false;
            foreach (var theory_test_application in result)
            {
                theory_test_application.FirstName = theory_test_application.Instructor_Category_Candidate.User.FirstName;
                theory_test_application.LastName = theory_test_application.Instructor_Category_Candidate.User.LastName;
            }
            dgvTheoryTestApplicationsData.DataSource = result;
        }

        private void DgvTheoryTestApplicationsData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            var id = dgvTheoryTestApplicationsData.SelectedRows[0].Cells[0].Value;
            frmTheoryTestApplicationsUpdate frm = new frmTheoryTestApplicationsUpdate(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void FrmTheoryTestApplicationsData_Load(object sender, EventArgs e)
        {
            TheoryTestApplicationsSearchRequest search_request = new TheoryTestApplicationsSearchRequest();
            search_request.Status = Model.Status.Active;
            var result = await _theory_test_applicationsService.GetAll<List<Model.TheoryTestApplications>>(search_request);
            foreach (var theory_test_application in result)
            {
                theory_test_application.FirstName = theory_test_application.Instructor_Category_Candidate.User.FirstName;
                theory_test_application.LastName = theory_test_application.Instructor_Category_Candidate.User.LastName;
                theory_test_application.Username = theory_test_application.Instructor_Category_Candidate.User.Username;
                var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(theory_test_application.Instructor_Category_Candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                theory_test_application.Category = category.Name;
            }
            dgvTheoryTestApplicationsData.AutoGenerateColumns = false;
            dgvTheoryTestApplicationsData.DataSource = result;
        }
    }
}

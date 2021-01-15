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
    }
}

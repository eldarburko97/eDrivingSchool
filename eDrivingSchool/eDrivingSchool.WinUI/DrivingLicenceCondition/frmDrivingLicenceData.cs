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

namespace eDrivingSchool.WinUI.DrivingLicenceCondition
{
    public partial class frmDrivingLicenceData : Form
    {
        private APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        private APIService _theory_test_applicationsService = new APIService("TheoryTestApplications");
        public frmDrivingLicenceData()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new TheoryTestApplicationsSearchRequest
            {
                Status = (Model.Status) Enum.Parse(typeof(Model.Status), txtSearch.Text, true)
            };
            /*
            var result = await _apiService.GetAll<List<Model.Candidate>>(search);
            dgvCandidatesData.DataSource = result;*/
        }
    }
}

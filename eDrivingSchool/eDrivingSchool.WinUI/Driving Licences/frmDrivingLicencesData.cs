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
        public frmDrivingLicencesData()
        {
            InitializeComponent();
        }

        private void DgvDrivingLicencesData_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
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

        }
    }
}

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

namespace eDrivingSchool.WinUI.Candidate
{
    public partial class frmCandidatesData : Form
    {
        private APIService _apiService = new APIService("Candidates");
        public frmCandidatesData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new CandidateSearchRequest
            {
                FirstName = txtSearch.Text
            };
            var result = await _apiService.GetAll<List<Model.Candidate>>(search);
            dgvCandidatesData.DataSource = result;
        }

        private void DgvCandidatesData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvCandidatesData.SelectedRows[0].Cells[0].Value;
            frmAddCandidate frm = new frmAddCandidate(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

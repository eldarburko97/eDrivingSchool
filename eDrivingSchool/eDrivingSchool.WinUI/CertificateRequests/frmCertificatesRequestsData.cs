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

namespace eDrivingSchool.WinUI.CertificateRequests
{
    public partial class frmCertificatesRequestsData : Form
    {
        private APIService _apiService = new APIService("Certificate_Requests");
        private APIService _candidateService = new APIService("Candidates");
        public frmCertificatesRequestsData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new Certificate_RequestSearch
            {
                //Status = txtSearch.Text,
            };
            if (txtSearch.Text.Contains(" "))
            {
                txtSearch.Text.Replace(" ", "_");
            }
            Certificate_Request_Status status;
            if (Enum.TryParse(txtSearch.Text, out status))
            {
                search.Status = status;
            }
            var result = await _apiService.GetAll<List<Model.Certificate_Request>>(search);
            foreach (var item in result)
            {
                var candidate = await _candidateService.GetById<Model.Candidate>(item.UserId);
                item.FirstName = candidate.FirstName;
                item.LastName = candidate.LastName;
                item.Type = item.Certificate.Type;
            }
            dgvCertificate_RequestsData.AutoGenerateColumns = false;
            dgvCertificate_RequestsData.DataSource = result;
        }

        private void DgvCertificate_RequestsData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvCertificate_RequestsData.SelectedRows[0].Cells[0].Value;
            frmUpdateCertificateRequest frm = new frmUpdateCertificateRequest(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

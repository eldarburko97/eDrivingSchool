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

namespace eDrivingSchool.WinUI.Certificate
{
    public partial class frmCertificatesData : Form
    {
        private APIService _apiService = new APIService("Certificates");
        public frmCertificatesData()
        {
            InitializeComponent();
        }



        private void DgvCertificatesData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvCertificatesData.SelectedRows[0].Cells[0].Value;
            frmAddCertificate frm = new frmAddCertificate(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            decimal validValue;
            var search = new CertificateSearchRequest
            {
                Type = Decimal.TryParse(txtSearch.Text, out validValue) ? " " : txtSearch.Text,
                Price = Decimal.TryParse(txtSearch.Text, out validValue) ? validValue : 0
            };
            var result = await _apiService.GetAll<List<Model.Certificate>>(search);
            dgvCertificatesData.AutoGenerateColumns = false;
            dgvCertificatesData.DataSource = result;
        }
    }
}

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
    public partial class frmAddCertificate : Form
    {
        private int? _id = null;
        CertificateInsertRequest request = new CertificateInsertRequest();
        APIService _apiService = new APIService("Certificates");
        public frmAddCertificate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            request.Type = txtType.Text;
            request.Price = Convert.ToDecimal(txtPrice.Text);


            if (_id.HasValue)
            {
                await _apiService.Update<Model.Certificate>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Certificate>(request);
            }
        }

        private async void FrmAddCertificate_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.Certificate>(_id);
                txtType.Text = request.Type;
                txtPrice.Text = request.Price.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.TechnicalInspection
{
    public partial class frmAddTechnicalInspection : Form
    {
        private APIService _apiService = new APIService("TechnicalInspections");
        private int? _id = null;
        Model.Requests.TechnicalInspectionInsertRequest request = new Model.Requests.TechnicalInspectionInsertRequest();
        public frmAddTechnicalInspection(int? id = null)
        {
            InitializeComponent();
            _id = id;
            this.WindowState = FormWindowState.Maximized;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Name = txtName.Text;
            request.Address = txtAddress.Text;
            request.PhoneNumber = txtPhone.Text;
            request.Email = txtEmail.Text;


            if (_id.HasValue)
            {
                await _apiService.Update<Model.TechnicalInspection>(_id, request);
                frmTechnicalInspectionData frm = new frmTechnicalInspectionData();
                frm.Show();
                this.Hide();
            }
            else
            {
                await _apiService.Insert<Model.TechnicalInspection>(request);
                frmTechnicalInspectionData frm = new frmTechnicalInspectionData();
                frm.Show();
                this.Hide();
            }
        }

        private async void frmAddTechnicalInspection_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.TechnicalInspection>(_id);
                txtName.Text = request.Name;
                txtAddress.Text = request.Address;
                txtPhone.Text = request.PhoneNumber;
                txtEmail.Text = request.Email;
            }
        }
    }
}

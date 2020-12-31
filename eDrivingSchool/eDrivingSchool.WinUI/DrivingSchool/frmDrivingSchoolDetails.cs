using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.DrivingSchool
{
    public partial class frmDrivingSchoolDetails : Form
    {
        private int? _id = null;
        private APIService _apiService = new APIService("DrivingSchools");
        Model.Requests.DrivingSchoolInsertRequest request = new Model.Requests.DrivingSchoolInsertRequest();
        public frmDrivingSchoolDetails(int? id = null)
        {
            InitializeComponent();
            _id = id;
            this.WindowState = FormWindowState.Maximized;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Name = txtName.Text;
            request.Address = txtAddress.Text;
            request.Phone = txtPhone.Text;
            request.Email = txtEmail.Text;
            //request.Logo = txtLogo.Text;

            if (_id.HasValue)
            {
                await _apiService.Update<Model.DrivingSchool>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.DrivingSchool>(request);
            }
        }

        private async void frmDrivingSchoolDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.DrivingSchool>(_id);
                txtName.Text = request.Name;
                txtAddress.Text = request.Address;
                txtEmail.Text = request.Email;
                txtPhone.Text = request.Phone;
                //txtLogo.Text = request.Logo;
            }
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Logo = file;
                txtLogo.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBoxLogo.Image = image;
            }
        }
    }
}

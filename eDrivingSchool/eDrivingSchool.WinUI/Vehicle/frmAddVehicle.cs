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

namespace eDrivingSchool.WinUI.Vehicle
{
    public partial class frmAddVehicle : Form
    {
        private APIService _apiService = new APIService("Vehicles");
        private APIService _technicalInspectionsApiService = new APIService("TechnicalInspections");

        private int? _id = null;
        Model.Requests.VehicleInsertRequest request = new Model.Requests.VehicleInsertRequest();
        public frmAddVehicle(int? id=null)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void frmAddVehicle_Load(object sender, EventArgs e)
        {
            await LoadTechnicalInspections();

            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.Vehicle>(_id);
               // txtName.Text = request.Name;
                txtModel.Text = request.Model;
                txtYear.Text = request.Year.ToString();
                txtPower.Text = request.Power.ToString();
                pictureBoxImage.Image = byteArrayToImage(request.Image);
                txtLogo.Text = System.IO.Path.GetFileName(pictureBoxImage.ImageLocation);
                txtMileage.Text = request.Mileage.ToString();
                var technicalInspection = await _apiService.GetById<Model.TechnicalInspection>(request.TechnicalInspectionId);
                cmbTechnicalInspections.SelectedItem = technicalInspection;
            }
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Name = txtName.Text;
            request.Model = txtModel.Text;
            request.Year = int.Parse(txtYear.Text);
            request.Mileage = int.Parse(txtMileage.Text);
            request.Power = int.Parse(txtPower.Text);

            var idObj = cmbTechnicalInspections.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int TechnicalInspectionId))
            {
                request.TechnicalInspectionId = TechnicalInspectionId;
            }
            if (_id.HasValue)
            {
                await _apiService.Update<Model.Vehicle>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Vehicle>(request);
            }
        }

        private async Task LoadTechnicalInspections()
        {
            var result = await _technicalInspectionsApiService.GetAll<List<Model.TechnicalInspection>>(null);
            result.Insert(0, new Model.TechnicalInspection());
            cmbTechnicalInspections.DisplayMember = "Name";
            cmbTechnicalInspections.ValueMember = "Id";
            cmbTechnicalInspections.DataSource = result;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Image = file;
                txtLogo.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBoxImage.Image = image;
            }
        }
    }
}

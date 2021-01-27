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

namespace eDrivingSchool.WinUI.Models
{
    public partial class frmAddModel : Form
    {
        ModelInsertRequest request = new ModelInsertRequest();
        APIService _apiService = new APIService("Models");
        APIService _manufacturerService = new APIService("Manufacturers");
        public frmAddModel()
        {
            InitializeComponent();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var idObj = cmbManufacturers.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int ManufacturerId))
            {
                request.ManufacturerId = ManufacturerId;
            }
            request.Name = txtModel.Text;
            await _apiService.Insert<Model.Model>(request);
        }

        private async void FrmAddModel_Load(object sender, EventArgs e)
        {
            await LoadManufacturers();
        }

        private async Task LoadManufacturers()
        {
            var result = await _manufacturerService.GetAll<List<Model.Manufacturer>>(null);
            result.Insert(0, new Model.Manufacturer());
            cmbManufacturers.DisplayMember = "Name";
            cmbManufacturers.ValueMember = "Id";
            cmbManufacturers.DataSource = result;
        }
    }
}

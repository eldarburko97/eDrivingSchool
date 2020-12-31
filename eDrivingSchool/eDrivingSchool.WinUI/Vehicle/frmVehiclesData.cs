using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.Vehicle
{
    public partial class frmVehiclesData : Form
    {
        private APIService _apiService = new APIService("Vehicles");

        public frmVehiclesData()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void frmVehiclesData_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetAll<List<Model.Vehicle>>(null);
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.DataSource = result;
        }

        private void dgvVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvVehicles.SelectedRows[0].Cells[0].Value;
            frmAddVehicle frm = new frmAddVehicle(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

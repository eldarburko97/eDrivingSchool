using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.DrivingSchool
{
    public partial class frmDrivingSchoolData : Form
    {
        private APIService _apiService = new APIService("DrivingSchools");

        public frmDrivingSchoolData()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void frmDrivingSchoolData_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetAll<List<Model.DrivingSchool>>(null);
            dgvDrivingSchool.AutoGenerateColumns = false;
            dgvDrivingSchool.DataSource = result;
        }

        private void dgvDrivingSchool_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvDrivingSchool.SelectedRows[0].Cells[0].Value;
            frmDrivingSchoolDetails frm = new frmDrivingSchoolDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

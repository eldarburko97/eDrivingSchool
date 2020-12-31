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
    public partial class frmTechnicalInspectionData : Form
    {
        private APIService _apiService = new APIService("TechnicalInspections");

        public frmTechnicalInspectionData()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void dgvTechnicalInspections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTechnicalInspections.SelectedRows[0].Cells[0].Value;
            frmAddTechnicalInspection frm = new frmAddTechnicalInspection(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmTechnicalInspectionData_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetAll<List<Model.TechnicalInspection>>(null);
            dgvTechnicalInspections.AutoGenerateColumns = false;
            dgvTechnicalInspections.DataSource = result;
        }
    }
}

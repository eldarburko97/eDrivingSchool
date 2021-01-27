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

namespace eDrivingSchool.WinUI.Manufacturers
{
    public partial class frmManufacturersData : Form
    {
        private APIService _apiService = new APIService("Manufacturers");
        public frmManufacturersData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new ManufacturerSearchRequest
            {
                Name = txtSearch.Text
            };
            var result = await _apiService.GetAll<List<Model.Manufacturer>>(search);
            dgvManufacturersData.DataSource = result;
        }

        /*
        private void DgvManufacturersData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvManufacturersData.SelectedRows[0].Cells[0].Value;
            frmAddCandidate frm = new frmAddCandidate(int.Parse(id.ToString()));
            frm.Show();
        }*/
    }
}

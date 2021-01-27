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
    public partial class frmModelsData : Form
    {
        private APIService _apiService = new APIService("Models");
        public frmModelsData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new ModelSearchRequest
            {
                Name = txtSearch.Text
            };
            var result = await _apiService.GetAll<List<Model.Model>>(search);
            foreach (var item in result)
            {
                item.ManufacturerName = item.Manufacturer.Name;
            }
            dgvModelsData.AutoGenerateColumns = false;
            dgvModelsData.DataSource = result;
        }
    }
}

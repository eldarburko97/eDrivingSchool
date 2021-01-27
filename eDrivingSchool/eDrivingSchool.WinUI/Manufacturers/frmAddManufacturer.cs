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
    public partial class frmAddManufacturer : Form
    {
        ManufacturerInsertRequest request = new ManufacturerInsertRequest();
        APIService _apiService = new APIService("Manufacturers");
        public frmAddManufacturer()
        {
            InitializeComponent();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            request.Name = txtManufacturer.Text;
            await _apiService.Insert<Model.Manufacturer>(request);
        }
    }
}

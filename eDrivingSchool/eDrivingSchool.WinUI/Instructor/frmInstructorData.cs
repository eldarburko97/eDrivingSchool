using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.Instructor
{
    public partial class frmInstructorData : Form
    {
        private APIService _apiService = new APIService("Instructors");
        public frmInstructorData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new Model.Requests.InstructorSearchRequest
            {
                FirstName = txtSearch.Text
            };
            var result = await _apiService.GetAll<List<Model.Instructor>>(search);
            // dgvInstructorsData.AutoGenerateColumns = false;
            dgvInstructorsData.DataSource = result;
        }

        private void DgvInstructorsData_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvInstructorsData.SelectedRows[0].Cells[0].Value;
            frmAddInstructor frm = new frmAddInstructor(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

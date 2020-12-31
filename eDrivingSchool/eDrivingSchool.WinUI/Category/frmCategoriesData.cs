using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.Category
{
    public partial class frmCategoriesData : Form
    {
        private APIService _apiService = new APIService("Categories");
        public frmCategoriesData()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void frmCategoriesData_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetAll<List<Model.Category>>(null);
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.DataSource = result;
        }

        private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvCategories.SelectedRows[0].Cells[0].Value;
            frmAddCategory frm = new frmAddCategory(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

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
    public partial class frmAddCategory : Form
    {
        private APIService _apiService = new APIService("Categories");
        private int? _id = null;
        public frmAddCategory(int? id = null)
        {
            InitializeComponent();
            _id = id;
            this.WindowState = FormWindowState.Maximized;
        }

        Model.Requests.CategoryInsertRequest request = new Model.Requests.CategoryInsertRequest();
        private async void frmAddCategory_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.Category>(_id);
                txtCategory.Text = request.Name;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Name = txtCategory.Text;

            if (_id.HasValue)
            {
                await _apiService.Update<Model.Category>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Category>(request);
            }
        }
    }
}

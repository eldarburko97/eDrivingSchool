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

namespace eDrivingSchool.WinUI.Payment
{
    public partial class frmPaymentData : Form
    {
        private APIService _apiService = new APIService("Payments");
        public frmPaymentData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new PaymentSearchRequest
            {
                Category = txtSearch.Text
            };
            var result = await _apiService.GetAll<List<Model.Payment>>(search);
            foreach (var payment in result)
            {
                payment.FirstName = payment.User.FirstName;
                payment.LastName = payment.User.LastName;
            }
            dgvPaymentsData.AutoGenerateColumns = false;
            dgvPaymentsData.DataSource = result;
        }

        private void DgvPaymentsData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPaymentsData.SelectedRows[0].Cells[0].Value;
            frmAddPayment frm = new frmAddPayment(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

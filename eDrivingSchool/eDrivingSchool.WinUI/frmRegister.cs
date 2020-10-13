using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI
{
    public partial class frmRegister : Form
    {
        private APIService _apiService = new APIService("Users");
        public frmRegister()
        {
            InitializeComponent();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Requests.UserInsertRequest request = new Model.Requests.UserInsertRequest();
                request.FirstName = txtFirstName.Text;
                request.LastName = txtLastName.Text;
                request.Email = txtEmail.Text;
                request.JMBG = txtJMBG.Text;
                request.Username = txtUsername.Text;
                request.Password = txtPassword.Text;
                request.PasswordConfirm = txtPasswordConfirm.Text;
                request.DrivingSchoolId = 1;
                request.RoleId = 1;
                request.Birthdate = dtpBirthdate.Value;
                await _apiService.Register<Model.User>(request);
                frmMain frm = new frmMain();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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

namespace eDrivingSchool.WinUI
{
    public partial class frmLogin : Form
    {
        private APIService _apiService = new APIService("Users");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                UserLoginRequest request = new UserLoginRequest()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text

                };
                //   await _apiService.Login<Models.Korisnik>(request);

                //   await _apiService.Get<dynamic>(null);
                await _apiService.GetById<Model.User>(1);

                frmMain frm = new frmMain();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

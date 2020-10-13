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

namespace eDrivingSchool.WinUI.Candidate
{
    public partial class frmAddCandidate : Form
    {
        private int? _id = null;
        CandidateInsertRequest request = new CandidateInsertRequest();
        APIService _apiService = new APIService("Candidates");
        public frmAddCandidate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            request.FirstName = txtFirstName.Text;
            request.LastName = txtLastName.Text;
            request.Phone = txtPhone.Text;
            request.Email = txtEmail.Text;
            request.Address = txtAddress.Text;
            request.Birthdate = dtpBirthdate.Value;
            request.JMBG = txtJMBG.Text;
            request.Username = txtUsername.Text;
            request.Password = txtPassword.Text;
            request.DrivingSchoolId = 1;
            request.RoleId = 3;        //RoleId je 3 kod kandidata

            if (_id.HasValue)
            {
                await _apiService.Update<Model.Candidate>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Candidate>(request);
            }
        }

        private async void FrmAddCandidate_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.Candidate>(_id);
                txtFirstName.Text = request.FirstName;
                txtLastName.Text = request.LastName;
                txtPhone.Text = request.Phone;
                txtEmail.Text = request.Email;
                txtAddress.Text = request.Address;
                dtpBirthdate.Value = Convert.ToDateTime(request.Birthdate);
                txtJMBG.Text = request.JMBG;
                txtUsername.Text = request.Username;
            }
        }
    }
}

using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.Instructor
{
    public partial class frmAddInstructor : Form
    {
        private int? _id = null;
        InstructorInsertRequest request = new InstructorInsertRequest();
        APIService _apiService = new APIService("Instructors");
        public frmAddInstructor(int? id = null)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            _id = id;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
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
                request.Salary = txtSalary.Text;
                request.LicenseNumber = txtLicenseNumber.Text;
                request.DateOfHiring = dtpDateOfHiring.Value;
                request.RoleId = 2;

                if (string.IsNullOrWhiteSpace(txtPhoto.Text))
                {
                    Assembly asm = Assembly.GetExecutingAssembly();
                    Stream stm = asm.GetManifestResourceStream("eDrivingSchool.WinUI.Image.userDefault.png");

                    using (var memoryStream = new MemoryStream())
                    {
                        stm.CopyTo(memoryStream);
                        var file = memoryStream.ToArray();
                        request.Image = file;
                    }

                }

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Instructor>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.Instructor>(request);
                }
            }
        }

        private async void FrmAddInstructor_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var request = await _apiService.GetById<Model.Instructor>(_id);
                txtFirstName.Text = request.FirstName;
                txtLastName.Text = request.LastName;
                txtPhone.Text = request.Phone;
                txtEmail.Text = request.Email;
                txtAddress.Text = request.Address;
                dtpBirthdate.Value = Convert.ToDateTime(request.Birthdate);
                txtJMBG.Text = request.JMBG;
                txtUsername.Text = request.Username;
                txtSalary.Text = request.Salary;
                txtLicenseNumber.Text = request.LicenseNumber;
                dtpDateOfHiring.Value = Convert.ToDateTime(request.DateOfHiring);
                pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream(request.Image));
            }
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Image = file;
                txtPhoto.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;

            }
        }

        private void TxtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, Messages.Validation_Field_Required);
            }
            else if (!Regex.IsMatch(txtFirstName.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, Messages.string_err);
            }
        }

        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLastName, Messages.Validation_Field_Required);
            }
            else if (!Regex.IsMatch(txtLastName.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLastName, Messages.string_err);
            }
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPhone, Messages.Validation_Field_Required);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Messages.Validation_Field_Required);
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Messages.email_err);
            }
        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAddress, Messages.Validation_Field_Required);
            }
        }

        private void TxtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtJMBG, Messages.Validation_Field_Required);
            }
            else if(!Regex.IsMatch(txtJMBG.Text, @"^[0-9]{13}$"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtJMBG, Messages.jmbg_err);
            }
        }

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Messages.Validation_Field_Required);
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, Messages.Validation_Field_Required);
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, Messages.password_err);
            }
        }

        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSalary, Messages.Validation_Field_Required);
            }
        }

        private void TxtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLicenseNumber, Messages.Validation_Field_Required);
            }
        }
    }
}

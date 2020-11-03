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
            request.Salary = txtSalary.Text;
            request.LicenseNumber = txtLicenseNumber.Text;
            request.DateOfHiring = dtpDateOfHiring.Value;
            request.DrivingSchoolId = 1;
            request.RoleId = 2;

            if (string.IsNullOrWhiteSpace(txtPhoto.Text))
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                Stream stm = asm.GetManifestResourceStream("eDrivingSchool.WinUI.Image.userDefault.png");
                
                using (var memoryStream = new MemoryStream())
                {
                    stm.CopyTo(memoryStream);
                    var file= memoryStream.ToArray();
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
    }
}

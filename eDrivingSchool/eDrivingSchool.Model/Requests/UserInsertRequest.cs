using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class UserInsertRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string JMBG { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int DrivingSchoolId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthdate { get; set; }
        public string JMBG { get; set; }
        public byte[] Image { get; set; }
        public string Username { get; set; }
        public string Salary { get; set; }
        public string LicenseNumber { get; set; }
        public string DateOfHiring { get; set; }
    }
}

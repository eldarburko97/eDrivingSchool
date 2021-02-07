using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string JMBG { get; set; }
        public string Username { get; set; }
        public string Salary { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime DateOfHiring { get; set; }
        public int RoleId { get; set; }
        public byte[] Image { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}

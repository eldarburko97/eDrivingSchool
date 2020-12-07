using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class User   //This class represents Administrator, Instructors and Candidates
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string JMBG { get; set; }
        public byte[] Image { get; set; }

        public string Salary { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime DateOfHiring { get; set; }
        [Required]
        public int DrivingSchoolId { get; set; }
        public DrivingSchool DrivingSchool { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

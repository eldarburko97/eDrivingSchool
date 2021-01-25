using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class InstructorInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string JMBG { get; set; }
        public byte[] Image { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Salary { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LicenseNumber { get; set; }
        public DateTime DateOfHiring { get; set; }
        public int RoleId { get; set; }
    }
}

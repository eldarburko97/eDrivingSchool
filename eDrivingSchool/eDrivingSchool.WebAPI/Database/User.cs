using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class User   //This class represents Administrator, Instructors and Candidates
    {
        public int Id { get; set; }
        [StringLength(50)]

        public string Username { get; set; }
        [StringLength(50)]
        public string PasswordHash { get; set; }
        [StringLength(50)]
        public string PasswordSalt { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }
        [StringLength(13)]
        public string JMBG { get; set; }
        public byte[] Image { get; set; }
        public string Salary { get; set; }
        public string LicenseNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfHiring { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Instructor_Category_Candidate  //This class represents relation between  Instructor_Category and Candidate (User table with RoleId == 3)
    {
        [Key]
        public int InstructorCategoryCandidateId { get; set; }

        public int Instructor_CategoryId { get; set; }
        [ForeignKey("Instructor_CategoryId")]
        public Instructor_Category Instructor_Category { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }                // Candidate
    }
}

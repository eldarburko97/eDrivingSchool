using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Instructor_Category // This class represents relation between Instructor (table User with RoleId == 2) and Category
    {
        public int InstructorId { get; set; }
        public User Instructor { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Instructor_Category_Candidate> Instructor_Category_Candidates { get; set; }
    }
}

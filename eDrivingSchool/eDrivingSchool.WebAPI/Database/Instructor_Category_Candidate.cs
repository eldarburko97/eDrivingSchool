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
        public int InstructorId { get; set; }       
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }        
        public virtual Instructor_Category Instructor_Category { get; set; }
        public virtual User Candidate { get; set; }
        public ICollection<DrivingTestApplications> DrivingTestApplications { get; set; }
        public ICollection<TheoryTestApplications> TheoryTestApplications { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<DrivingLesson> DrivingLessons { get; set; }

        public bool PolozenTeorijskiTest { get; set; }
        public bool PolozenTestPrvePomoci { get; set; }
        public bool PolozenPrakticniTest { get; set; }
        public bool Prijavljen { get; set; }
        public int NumberOfLessons { get; set; }
        public bool Paid { get; set; }
        [Column(TypeName ="date")]
        public DateTime? Date { get; set; }
    }
}

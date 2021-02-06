using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class TheoryTestApplications
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public bool FirstAid { get; set; }
        public bool TheoryTest { get; set; }
        // public int Status { get; set; }
        public bool Active { get; set; }

        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }

        public virtual Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
    }
}

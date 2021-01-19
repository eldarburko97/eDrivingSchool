using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class DrivingTestApplications
    {
        [Key]
        public int Id { get; set; }
        public int Instructor_Category_CandidateId { get; set; }
        [ForeignKey("Instructor_Category_CandidateId")]
        public Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public bool Passed { get; set; }
    }
}

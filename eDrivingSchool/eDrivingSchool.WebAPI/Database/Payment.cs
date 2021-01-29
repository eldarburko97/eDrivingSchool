using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Payment
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public string Note { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfPayment { get; set; }
        public int Instructor_Category_CandidateId { get; set; }
        public Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
    }
}

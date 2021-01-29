using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public int Instructor_Category_CandidateId { get; set; }
        public Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Category { get; set; }
        public float Amount { get; set; }
        public string DateOfPayment { get; set; }
        public string Note { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class TheoryTestApplicationsInsertRequest
    {
        public int Instructor_Category_CandidateId { get; set; }
        public DateTime Date { get; set; }
        public bool FirstAid { get; set; }
        public int Status { get; set; }
    }
}

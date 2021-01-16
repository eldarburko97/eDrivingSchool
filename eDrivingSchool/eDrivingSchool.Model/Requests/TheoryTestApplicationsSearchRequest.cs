using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class TheoryTestApplicationsSearchRequest
    {
        public int Instructor_Category_CandidateId { get; set; }
        public Status Status { get; set; }
    }
}

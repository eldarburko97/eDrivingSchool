using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class DrivingTestApplicationsInsertRequest
    {
        public int Instructor_Category_CandidateId { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
    }
}

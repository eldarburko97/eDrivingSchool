using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public enum Status
    {
        Inactive,
        Active,
        Expired
    }
    public class TheoryTestApplications
    {
        public int Instructor_Category_CandidateId { get; set; }
        public DateTime Date { get; set; }
        public bool FirstAid { get; set; }
        public Status Status { get; set; }
    }
}

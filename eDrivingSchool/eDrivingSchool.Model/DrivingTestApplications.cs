using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class DrivingTestApplications
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }

        // public int Instructor_Category_CandidateId { get; set; }
        public Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
        public DateTime Date { get; set; }
        // public Status Status { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Category { get; set; }
        //  public bool DrivingTestPassed { get; set; }
        public bool Passed { get; set; }
    }
}

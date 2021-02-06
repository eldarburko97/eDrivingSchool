using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eDrivingSchool.Model
{
    public enum Status
    {
        [Description("Inactive")]
        Inactive,
        [Description("Active")]
        Active,
        [Description("Expired")]
        Expired
    }
    public class TheoryTestApplications
    {
        public int Id { get; set; }
        //  public int Instructor_Category_CandidateId { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }
        public Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
        public DateTime Date { get; set; }
        public bool FirstAid { get; set; }
        public bool TheoryTest { get; set; }
        //  public Status Status { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Category { get; set; }
    //    public bool PolozenTestPrvePomoci { get; set; }
     //   public bool PolozenTeorijskiTest { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class InstructorCategoryCandidateSearchRequest
    {
        public int Id { get; set; }
        //   public int Instructor_CategoryId { get; set; }
        //  public int UserId { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }
        public bool PolozenPrakticniTest { get; set; }
        public bool Prijavljen { get; set; }
        public bool PolozenTeorijskiTest { get; set; }
        public bool PolozenTestPrvePomoci { get; set; }
        public bool Paid { get; set; }
        public DateTime? Date { get; set; }
    }
}

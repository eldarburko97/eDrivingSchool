using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class InstructorCategoryCandidateInsertRequest
    {        
        public bool Prijavljen { get; set; }
        public bool PolozenPrakticniTest { get; set; }
        public bool PolozenTeorijskiTest { get; set; }
        public bool PolozenTestPrvePomoci { get; set; }
        public int NumberOfLessons { get; set; }
        public bool Paid { get; set; }
        public DateTime? Date { get; set; }
    }
}

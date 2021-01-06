using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class InstructorCategoryCandidateSearchRequest
    {
        public int Id { get; set; }
        public int Instructor_CategoryId { get; set; }
        public int UserId { get; set; }
        public bool PolozenPrakticniTest { get; set; }
        public bool Prijavljen { get; set; }
        public bool PolozenTeorijskiTest { get; set; }
    }
}

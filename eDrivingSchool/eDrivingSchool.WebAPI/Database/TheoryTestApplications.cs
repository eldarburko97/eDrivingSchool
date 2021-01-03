using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class TheoryTestApplications
    {
        public int Id { get; set; }
        public int Instructor_Category_CandidateId { get; set; }
        public DateTime Date { get; set; }
        public bool FirstAid { get; set; }
        public int Status { get; set; }
    }
}

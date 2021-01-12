using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Instructor_Category_Candidate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Instructor_CategoryId { get; set; }
        public Instructor_Category Instructor_Category { get; set; }
    }
}

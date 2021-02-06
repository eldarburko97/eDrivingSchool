using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Instructor_Category
    {
        public int InstructorId { get; set; }
        public User Instructor { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

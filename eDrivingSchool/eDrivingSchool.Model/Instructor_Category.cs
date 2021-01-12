using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
   public class Instructor_Category
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

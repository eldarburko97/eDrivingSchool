using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Instructor_Category> Instructor_Categories { get; set; }
    }
}

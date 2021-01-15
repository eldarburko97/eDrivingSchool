using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Instructor_Category_Candidate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Instructor_CategoryId { get; set; }
        public Instructor_Category Instructor_Category { get; set; }
        public bool PolozenPrakticniTest { get; set; }
        public bool PolozenTeorijskiTest { get; set; }
        public bool PolozenTestPrvePomoci { get; set; }
        public bool Prijavljen { get; set; }
        public int NumberOfLessons { get; set; }
        public bool Paid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthdate { get; set; }
        public string JMBG { get; set; }
        public string Username { get; set; }
        public byte[] Image { get; set; }
        public bool isChecked { get; set; }
        public string candidate   // First_name + last_name
        {
            get { return FirstName + " " + LastName; }
        }
        public string category { get; set; }
        public string candidate_category { get; set; } // Candidate + category
    }
}

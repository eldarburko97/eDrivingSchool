using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public float Amount { get; set; }
        public string DateOfPayment { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Certificate
    {
        public int Id { get; set; }
        public string Purpose { get; set; }
        public string Datum { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Svrha { get; set; }
    }
}

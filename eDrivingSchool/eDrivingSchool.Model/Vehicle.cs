using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
   public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public int Mileage { get; set; }
    }
}

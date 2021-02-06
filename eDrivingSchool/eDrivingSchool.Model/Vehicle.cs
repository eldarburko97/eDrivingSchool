using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
   public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public int Mileage { get; set; }
        public int TechnicalInspectionId { get; set; }
        public byte[] Image { get; set; }
        public string RegistrationNumber { get; set; }
        public string vehicle { get; set; } // Model + registration number
    }
}

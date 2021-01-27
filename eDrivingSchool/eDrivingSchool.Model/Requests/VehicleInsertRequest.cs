using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class VehicleInsertRequest
    {
        public int ModelId { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public float Mileage { get; set; }
        public int TechnicalInspectionId { get; set; }
        public byte[] Image { get; set; }
        public string RegistrationNumber { get; set; }
    }
}

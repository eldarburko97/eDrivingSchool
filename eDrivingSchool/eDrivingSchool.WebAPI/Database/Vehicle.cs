﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public float Mileage { get; set; }
        public int TechnicalInspectionId { get; set; }
        public TechnicalInspection TechnicalInspection { get; set; }
        public byte[] Image { get; set; }
        public string RegistrationNumber { get; set; }
    }
}

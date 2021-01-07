using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
   public class DrivingLesson
    {
        public int UserId { get; set; }
        public int VehicleId { get; set; }
        public float Mileage { get; set; }
        public float AverageFuelConsumption { get; set; }
        public string Damage { get; set; }
        public DateTime Date { get; set; }
        public int InstructorId { get; set; }
    }
}

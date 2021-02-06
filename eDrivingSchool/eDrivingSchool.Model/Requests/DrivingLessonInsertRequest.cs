using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class DrivingLessonInsertRequest
    {
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }
        public int VehicleId { get; set; }
        public float Mileage { get; set; }
        public float AverageFuelConsumption { get; set; }
        public string Damage { get; set; }
        public DateTime Date { get; set; }
    }
}

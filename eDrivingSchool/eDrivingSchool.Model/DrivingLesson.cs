using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class DrivingLesson
    {
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }
        public int VehicleId { get; set; }
        public float Mileage { get; set; }
        public float AverageFuelConsumption { get; set; }
        public string Damage { get; set; }
        public DateTime Date { get; set; }
        public Instructor_Category_Candidate Instructor_Category_Candidate { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}

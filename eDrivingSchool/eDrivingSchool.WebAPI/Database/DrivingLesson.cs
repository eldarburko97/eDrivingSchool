using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class DrivingLesson
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }   // Candidate
        public int VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }
        public float Mileage { get; set; }   // Number of kilometers traveled on driving lesson
        public float AverageFuelConsumption { get; set; }
        public string Damage { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public User Instructor { get; set; }
    }
}

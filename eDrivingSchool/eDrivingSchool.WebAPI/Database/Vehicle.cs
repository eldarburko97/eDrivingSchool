using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public float Mileage { get; set; }
        public int ModelId { get; set; }
        [ForeignKey("ModelId")]
        public Model Model { get; set; }
        public int TechnicalInspectionId { get; set; }
        public TechnicalInspection TechnicalInspection { get; set; }
        public byte[] Image { get; set; }
        public string RegistrationNumber { get; set; }
        public ICollection<DrivingLesson> DrivingLessons { get; set; }
    }
}

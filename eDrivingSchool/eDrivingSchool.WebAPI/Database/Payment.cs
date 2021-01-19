using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Payment
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfPayment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

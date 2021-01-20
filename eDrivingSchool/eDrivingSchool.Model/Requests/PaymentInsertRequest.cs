using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class PaymentInsertRequest
    {
        [Required]
        public int UserId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Category { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public DateTime DateOfPayment { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Note { get; set; }
    }
}

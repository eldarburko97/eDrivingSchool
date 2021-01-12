using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class PaymentInsertRequest
    {
        public int UserId { get; set; }
        public string Category { get; set; }
        public float Amount { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string Note { get; set; }
    }
}

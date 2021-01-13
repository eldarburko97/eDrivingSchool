using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class PaymentSearchRequest
    {
        public string Category { get; set; }
        public int UserId { get; set; }
    }
}

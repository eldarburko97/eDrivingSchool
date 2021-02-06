using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class PaymentSearchRequest
    {
        public string Category { get; set; }
        public string Username { get; set; }
        public int CandidateId { get; set; }
    }
}

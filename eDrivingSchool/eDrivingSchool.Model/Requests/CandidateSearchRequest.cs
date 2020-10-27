using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class CandidateSearchRequest
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

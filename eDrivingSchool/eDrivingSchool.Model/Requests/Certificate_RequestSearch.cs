using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class Certificate_RequestSearch
    {
        public int UserId { get; set; }
        public Certificate_Request_Status Status { get; set; }
    }
}

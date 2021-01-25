using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class Certificate_RequestInsert
    {
        public int UserId { get; set; }
        public int CertificateId { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public Certificate_Request_Status Status { get; set; }
    }
}

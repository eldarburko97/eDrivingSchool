using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Certificate_Request
    {
        public int CertificateRequestId { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public int UserId { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public Certificate_Request_Status Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Certificate_Request
    {
        public int Id { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}

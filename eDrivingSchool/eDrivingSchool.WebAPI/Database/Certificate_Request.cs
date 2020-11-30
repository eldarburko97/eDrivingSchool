using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Certificate_Request
    {
        public int Id { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public int UserId { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}

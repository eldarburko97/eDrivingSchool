using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Certificate_Request
    {
        [Key]
        public int CertificateRequestId { get; set; }

        public int CertificateId { get; set; }
        [ForeignKey("CertificateId")]
        public Certificate Certificate { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}

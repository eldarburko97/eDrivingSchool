using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class CertificateInsertRequest
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}

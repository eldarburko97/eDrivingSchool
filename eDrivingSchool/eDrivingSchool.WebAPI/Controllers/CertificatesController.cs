using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : BaseCRUDController<Model.Certificate, CertificateSearchRequest, CertificateInsertRequest, CertificateInsertRequest>
    {
        public CertificatesController(ICRUDService<Model.Certificate, CertificateSearchRequest, CertificateInsertRequest, CertificateInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class CertificateService : CRUDService<Model.Certificate, CertificateSearchRequest, Database.Certificate, CertificateInsertRequest, CertificateInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public CertificateService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}

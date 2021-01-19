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

        public override List<Model.Certificate> GetAll(CertificateSearchRequest request)
        {
            var query = _context.Set<Database.Certificate>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Type))
            {
                query = query.Where(x => x.Type == request.Type);
            }
            if (request.Price != 0)
            {
                query = query.Where(x => x.Price == request.Price);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Certificate>>(list);
        }
    }
}

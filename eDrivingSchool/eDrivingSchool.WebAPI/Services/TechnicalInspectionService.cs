using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class TechnicalInspectionService : CRUDService<Model.TechnicalInspection, TechnicalInspectionSearchRequest, Database.TechnicalInspection, TechnicalInspectionInsertRequest, TechnicalInspectionInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public TechnicalInspectionService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override List<Model.TechnicalInspection> GetAll(TechnicalInspectionSearchRequest searchRequest)
        {
            var query = _context.Set<Database.TechnicalInspection>().AsQueryable();

            if (!string.IsNullOrEmpty(searchRequest.Name))
            {
                query = query.Where(x => x.Name.Contains(searchRequest.Name));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.TechnicalInspection>>(list);
        }
    }
}

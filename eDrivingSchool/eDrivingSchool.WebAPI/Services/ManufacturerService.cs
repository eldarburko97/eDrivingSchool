using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class ManufacturerService : CRUDService<Model.Manufacturer, ManufacturerSearchRequest, Database.Manufacturer, ManufacturerInsertRequest, ManufacturerInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public ManufacturerService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Manufacturer> GetAll(ManufacturerSearchRequest request)
        {
            var query = _context.Set<Database.Manufacturer>().AsQueryable();

            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(x => x.Name == request.Name);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Manufacturer>>(list);
        }
    }
}

using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class ModelService : CRUDService<Model.Model, ModelSearchRequest, Database.Model, ModelInsertRequest, ModelInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public ModelService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override List<Model.Model> GetAll(ModelSearchRequest request)
        {
            var query = _context.Set<Database.Model>().AsQueryable();

            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(x => x.Name == request.Name);
            }
            var list = query.Include(i => i.Manufacturer).ToList();
            return _mapper.Map<List<Model.Model>>(list);
        }
    }
}

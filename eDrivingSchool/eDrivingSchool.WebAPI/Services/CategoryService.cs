using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class CategoryService : CRUDService<Model.Category, CategorySearchRequest, Database.Category, CategoryInsertRequest, CategoryInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public CategoryService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Category> GetAll(CategorySearchRequest request)
        {
            var query = _context.Set<Database.Category>().AsQueryable();

            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(x => x.Name == request.Name);
            }           
            var list = query.ToList();
            return _mapper.Map<List<Model.Category>>(list);
        }
    }
}

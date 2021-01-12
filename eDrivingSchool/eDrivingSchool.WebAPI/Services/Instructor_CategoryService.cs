using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class Instructor_CategoryService : CRUDService<Model.Instructor_Category, InstructorCategorySearchRequest, Database.Instructor_Category, InstructorCategoryInsertRequest, InstructorCategoryInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public Instructor_CategoryService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Instructor_Category> GetAll(InstructorCategorySearchRequest request)
        {
            var query = _context.Set<Database.Instructor_Category>().AsQueryable();

          

            if (request != null && request.UserId != 0)
            {
                query = query.Where(x => x.UserId == request.UserId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Instructor_Category>>(list);
        }

       
    }
}

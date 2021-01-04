using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class Instructor_Category_CandidateService : CRUDService<Model.Instructor_Category_Candidate, InstructorCategoryCandidateSearchRequest, Database.Instructor_Category, InstructorCategoryCandidateInsertRequest, InstructorCategoryCandidateInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public Instructor_Category_CandidateService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Instructor_Category_Candidate> GetAll(InstructorCategoryCandidateSearchRequest request)
        {
            var query = _context.Set<Database.Instructor_Category_Candidate>().AsQueryable();



            if (request != null && request.Instructor_CategoryId != 0 )
            {
                query = query.Where(x => x.Instructor_CategoryId == request.Instructor_CategoryId && x.Polozio == false && x.Prijavljen == false);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Instructor_Category_Candidate>>(list);
        }
    }
}

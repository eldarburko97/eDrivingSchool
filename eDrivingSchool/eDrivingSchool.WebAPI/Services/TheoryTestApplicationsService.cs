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
    public class TheoryTestApplicationsService : CRUDService<Model.TheoryTestApplications, TheoryTestApplicationsSearchRequest, Database.TheoryTestApplications, TheoryTestApplicationsInsertRequest, TheoryTestApplicationsInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public TheoryTestApplicationsService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.TheoryTestApplications> GetAll(TheoryTestApplicationsSearchRequest request)
        {
            var query = _context.Set<Database.TheoryTestApplications>().AsQueryable();

            if (request != null && request.Status == Model.Status.Inactive)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            if (request != null && request.Status == Model.Status.Active)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            if (request != null && request.Status == Model.Status.Expired)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.TheoryTestApplications>>(list);
        }
    }
}

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
    public class DrivingTestApplicationsService : CRUDService<Model.DrivingTestApplications, DrivingTestApplicationsSearchRequest, Database.DrivingTestApplications, DrivingTestApplicationsInsertRequest, DrivingTestApplicationsInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public DrivingTestApplicationsService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.DrivingTestApplications> GetAll(DrivingTestApplicationsSearchRequest request)
        {
            var query = _context.Set<Database.DrivingTestApplications>().AsQueryable();

            if (request != null && request.Status == Model.Status.Active && request.Instructor_Category_CandidateId != 0)
            {
                query = query.Where(x => x.Status == (int)request.Status && x.Instructor_Category_CandidateId == request.Instructor_Category_CandidateId).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            else if (request != null && request.Status == Model.Status.Inactive)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            else if (request != null && request.Status == Model.Status.Active)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            else if (request != null && request.Status == Model.Status.Expired)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.DrivingTestApplications>>(list);
        }

        public override Model.DrivingTestApplications GetById(int id)
        {
            // var entity = _context.Set<Database.TheoryTestApplications>().Find(id);
            var query = _context.Set<Database.DrivingTestApplications>().AsQueryable();
            query = query.Where(w => w.Id == id).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.User);
            var list = query.ToList();
            var entity = list[0];
            return _mapper.Map<Model.DrivingTestApplications>(entity);
        }
    }
}

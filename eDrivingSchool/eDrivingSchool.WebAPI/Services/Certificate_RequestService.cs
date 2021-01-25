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
    public class Certificate_RequestService : CRUDService<Model.Certificate_Request, Certificate_RequestSearch, Database.Certificate_Request, Certificate_RequestInsert, Certificate_RequestInsert>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public Certificate_RequestService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Certificate_Request> GetAll(Certificate_RequestSearch searchRequest)
        {
            var query = _context.Set<Database.Certificate_Request>().AsQueryable();

            // query = query.Where(w => w.TopicId == searchRequest.TopicId);
            if (searchRequest != null && searchRequest.UserId != 0)
            {
                query = query.Where(q => q.UserId == searchRequest.UserId);
            }
            if (searchRequest != null && searchRequest.Status == Model.Certificate_Request_Status.On_processing)
            {
                query = query.Where(w => w.Status == (int)searchRequest.Status);
            }
            var list = query.Include(i => i.Certificate).ToList();
            return _mapper.Map<List<Model.Certificate_Request>>(query);
        }
    }
}

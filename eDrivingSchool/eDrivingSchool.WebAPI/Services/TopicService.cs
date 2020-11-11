using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class TopicService : CRUDService<Model.Topic, object, Database.Topic, TopicInsertRequest, TopicInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public TopicService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}

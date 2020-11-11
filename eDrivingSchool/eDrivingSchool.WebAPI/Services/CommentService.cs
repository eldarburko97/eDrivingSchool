using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class CommentService : CRUDService<Model.Comment, CommentSearchRequest, Database.Comment, CommentInsertRequest, CommentInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public CommentService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public  List<Model.Comment> GetAll(CommentSearchRequest searchRequest)
        {
            var query = _context.Set<Database.Comment>().AsQueryable();

           if(searchRequest.TopicId != 0)
            {
                query.Where(w => w.TopicId == searchRequest.TopicId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Comment>>(list);
        }
    }
}

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
    public class PaymentService : CRUDService<Model.Payment, PaymentSearchRequest, Database.Payment, PaymentInsertRequest, PaymentInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public PaymentService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Payment> GetAll(PaymentSearchRequest request)
        {
            var query = _context.Payments.AsQueryable();
            if (!string.IsNullOrEmpty(request.Type))
            {
                query = query.Where(x => x.Type == request.Type);
            }
            var list = query.Include("User").ToList();
            return _mapper.Map<List<Model.Payment>>(list);
        }
    }
}

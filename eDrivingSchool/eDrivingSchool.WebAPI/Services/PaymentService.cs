﻿using AutoMapper;
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
            /*
            if (!string.IsNullOrEmpty(request.Category))
            {
                query = query.Where(x => x.Category == request.Category);
            }
                if(request != null && request.UserId != 0)
                {
                    query = query.Where(w => w.UserId == request.UserId);
                }*/
            if (request != null && request.CandidateId != 0)
            {
                query = query.Where(w => w.CandidateId == request.CandidateId);
            }
            var list = query.Include(i => i.Instructor_Category_Candidate).ThenInclude(ii => ii.Candidate).ToList();
            return _mapper.Map<List<Model.Payment>>(list);
        }
    }
}

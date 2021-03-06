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
            /*

            if (request != null && request.Status == Model.Status.Active && request.InstructorId != 0 && request.CategoryId != 0 && request.CandidateId != 0)
            {
                query = query.Where(x => x.Status == (int)request.Status && x.InstructorId == request.InstructorId && x.CategoryId == request.CategoryId && x.CandidateId == request.CandidateId).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            }
            else if (request != null && request.Status == Model.Status.Inactive)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            }
            else if (request != null && request.Status == Model.Status.Active)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            }
            else if (request != null && request.Status == Model.Status.Expired)
            {
                query = query.Where(x => x.Status == (int)request.Status).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            }*/



            if (request != null && request.Active == true && request.Date != null)
            {
                query = query.Where(w => w.Active == request.Active && (w.Date < request.Date || w.Date == request.Date)).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            }
            else if (request != null && request.Active == false)
            {
                query = query.Where(z => z.Active == request.Active).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.TheoryTestApplications>>(list);
        }
        

            
        public override Model.TheoryTestApplications GetById(int id)
        {
            // var entity = _context.Set<Database.TheoryTestApplications>().Find(id);
            var query = _context.Set<Database.TheoryTestApplications>().AsQueryable();
            query = query.Where(w => w.Id == id).Include(i => i.Instructor_Category_Candidate).ThenInclude(t => t.Candidate);
            var list = query.ToList();
            var entity = list[0];
            return _mapper.Map<Model.TheoryTestApplications>(entity);
        }
        
    }
}

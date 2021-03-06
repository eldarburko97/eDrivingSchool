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
    public class Instructor_Category_CandidateService : CRUDService<Model.Instructor_Category_Candidate, InstructorCategoryCandidateSearchRequest, Database.Instructor_Category_Candidate, InstructorCategoryCandidateInsertRequest, InstructorCategoryCandidateInsertRequest>
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
            /*

            if (request != null && request.Instructor_CategoryId != 0 && request.UserId != 0 && (request.PolozenTeorijskiTest == false || request.PolozenTestPrvePomoci == false) && request.Prijavljen == false)    // Selects list of checked candidates of logged in instructor and instructor's category
            {
                query = query.Where(w => w.Instructor_CategoryId == request.Instructor_CategoryId && w.UserId == request.UserId && (w.PolozenTeorijskiTest == request.PolozenTeorijskiTest || w.PolozenTestPrvePomoci == request.PolozenTestPrvePomoci) && w.Prijavljen == request.Prijavljen).Include(i => i.Instructor_Category);
            }
            else if (request != null && request.Instructor_CategoryId != 0 && request.UserId != 0 && request.PolozenTeorijskiTest == true && request.PolozenPrakticniTest == false && request.Prijavljen == false)
            {
                query = query.Where(q => q.Instructor_CategoryId == request.Instructor_CategoryId && q.UserId == request.UserId && q.PolozenTeorijskiTest == request.PolozenTeorijskiTest && q.PolozenPrakticniTest == request.PolozenPrakticniTest && q.Prijavljen == request.Prijavljen).Include(i => i.Instructor_Category);
            }
            else if (request != null && request.Instructor_CategoryId != 0 && (request.PolozenTeorijskiTest == false || request.PolozenTestPrvePomoci == false) && request.Prijavljen == false) // Selects records for theory test applications of logged in instructors and his category
            {
                query = query.Where(x => x.Instructor_CategoryId == request.Instructor_CategoryId && (x.PolozenTeorijskiTest == request.PolozenTeorijskiTest || x.PolozenTestPrvePomoci == request.PolozenTestPrvePomoci) && x.Prijavljen == false).Include(i => i.Instructor_Category);
            }
            else if (request != null && request.Instructor_CategoryId != 0 && request.PolozenTeorijskiTest == true && request.PolozenTestPrvePomoci == true && request.PolozenPrakticniTest == false && request.Prijavljen == false) // Selects candidates (candidates who are assigned to logged in instructor) who have passed theory test
            {
                query = query.Where(z => z.Instructor_CategoryId == request.Instructor_CategoryId && z.PolozenTeorijskiTest == request.PolozenTeorijskiTest && z.PolozenTestPrvePomoci == request.PolozenTestPrvePomoci && z.PolozenPrakticniTest == request.PolozenPrakticniTest && z.Prijavljen == request.Prijavljen).Include(i => i.Instructor_Category);
            }
            else if (request != null && request.PolozenPrakticniTest == true && request.Prijavljen == false && request.Date != null)
            {
                query = query.Where(p => p.PolozenPrakticniTest == request.PolozenPrakticniTest && p.Prijavljen == request.Prijavljen && p.Date == request.Date).Include(i => i.Instructor_Category).ThenInclude(t => t.Category);
            }
            else if(request != null && request.PolozenPrakticniTest == true && request.Prijavljen == false )
            {
                query = query.Where(p => p.PolozenPrakticniTest == request.PolozenPrakticniTest && p.Prijavljen == request.Prijavljen && p.Paid == request.Paid).Include(i => i.Instructor_Category).ThenInclude(t => t.Category);
            }
            else if (request.Paid == false)
            {
                query = query.Where(p => p.Paid == request.Paid).Include(i => i.User);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Instructor_Category_Candidate>>(list);*/

            

          

            var list = query.ToList();
            return _mapper.Map<List<Model.Instructor_Category_Candidate>>(list);

        }



    }
}

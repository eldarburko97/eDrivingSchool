using AutoMapper;
using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class InstructorCategoryCandidateService : IInstructorCategoryCandidateService
    {
        private readonly ApplicationDbContext _context = null;
        private readonly IMapper _mapper = null;
        public InstructorCategoryCandidateService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Instructor_Category_Candidate Delete(int instructorId, int categoryId, int candidateId)
        {
            throw new NotImplementedException();
        }

        public List<Model.Instructor_Category_Candidate> GetAll(InstructorCategoryCandidateSearchRequest request)
        {
            var query = _context.Instructors_Categories_Candidates.AsQueryable();

            //Return all selected candidates of logged in instructor for theory test applications
            if (request != null && request.InstructorId != 0 && request.CategoryId != 0 && request.CandidateId != 0 && (request.PolozenTeorijskiTest == false || request.PolozenTestPrvePomoci == false) && request.Prijavljen == false)
            {
                query = query.Where(q => q.InstructorId == request.InstructorId && q.CategoryId == request.CategoryId && q.CandidateId == request.CandidateId && (q.PolozenTeorijskiTest == request.PolozenTeorijskiTest || q.PolozenTestPrvePomoci == request.PolozenTestPrvePomoci) && q.Prijavljen == request.Prijavljen).Include(i => i.Instructor_Category).ThenInclude(i => i.Category);
            }

            //Returns all candidates of logged in instructor for theory test applications
            else if (request != null && request.InstructorId != 0 && request.CategoryId != 0 && (request.PolozenTeorijskiTest == false || request.PolozenTestPrvePomoci == false) && request.Prijavljen == false)
            {
                query = query.Where(w => w.InstructorId == request.InstructorId && w.CategoryId == request.CategoryId && (w.PolozenTeorijskiTest == request.PolozenTeorijskiTest || w.PolozenTestPrvePomoci == request.PolozenTestPrvePomoci) && w.Prijavljen == request.Prijavljen).Include(i => i.Instructor_Category).ThenInclude(i => i.Category);
            }

            //Selects candidates (candidates who are assigned to logged in instructor) who have passed theory test 
            else if (request != null && request.InstructorId != 0 && request.CategoryId != 0 && request.PolozenTeorijskiTest == true && request.PolozenTestPrvePomoci == true && request.PolozenPrakticniTest == false && request.Prijavljen == false)
            {
                query = query.Where(z => z.InstructorId == request.InstructorId && z.CategoryId == request.CategoryId && z.PolozenTeorijskiTest == request.PolozenTeorijskiTest && z.PolozenTestPrvePomoci == request.PolozenTestPrvePomoci && z.PolozenPrakticniTest == request.PolozenPrakticniTest && z.Prijavljen == request.Prijavljen).Include(i => i.Instructor_Category).ThenInclude(i => i.Category);
            }
            else if (request != null && request.Paid == false)
            {
                query = query.Where(p => p.Paid == request.Paid).Include(i => i.Instructor_Category).ThenInclude(i => i.Category);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Instructor_Category_Candidate>>(list);

        }

        public Model.Instructor_Category_Candidate GetById(int instructorId, int categoryId, int candidateId)
        {
            var query = _context.Set<Database.Instructor_Category_Candidate>().AsQueryable();
            query = query.Where(w => w.InstructorId == instructorId && w.CategoryId == categoryId && w.CandidateId == candidateId).Include(i => i.Candidate);
            var list = query.ToList();
            var entity = list[0];
            return _mapper.Map<Model.Instructor_Category_Candidate>(entity);

        }

        public Model.Instructor_Category_Candidate Insert(InstructorCategoryCandidateInsertRequest request)
        {
            var entity = _mapper.Map<Database.Instructor_Category_Candidate>(request);
            _context.Instructors_Categories_Candidates.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Instructor_Category_Candidate>(entity);
        }

        public Model.Instructor_Category_Candidate Update(int instructorId, int categoryId, int candidateId, InstructorCategoryCandidateInsertRequest request)
        {
            var entity = _context.Instructors_Categories_Candidates.Where(w => w.InstructorId == instructorId && w.CategoryId == categoryId && w.CandidateId == candidateId).First();
            _mapper.Map(request, entity);
            _context.Instructors_Categories_Candidates.Attach(entity);
            _context.Instructors_Categories_Candidates.Update(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Instructor_Category_Candidate>(entity);
        }
    }
}

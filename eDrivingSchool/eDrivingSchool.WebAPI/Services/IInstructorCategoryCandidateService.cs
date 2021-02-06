using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
   public interface IInstructorCategoryCandidateService
    {
        List<Model.Instructor_Category_Candidate> GetAll(InstructorCategoryCandidateSearchRequest searchRequest);
        Model.Instructor_Category_Candidate GetById(int instructorId,int categoryId,int candidateId);
        Model.Instructor_Category_Candidate Insert(InstructorCategoryCandidateInsertRequest model);
        Model.Instructor_Category_Candidate Update(int instructorId,int categoryId,int candidateId, InstructorCategoryCandidateInsertRequest model);
        Model.Instructor_Category_Candidate Delete(int instructorId,int categoryId,int candidateId);
    }
}

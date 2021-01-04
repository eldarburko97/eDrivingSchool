using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Instructors_Categories_CandidatesController : BaseCRUDController<Model.Instructor_Category_Candidate, InstructorCategoryCandidateSearchRequest, InstructorCategoryCandidateInsertRequest, InstructorCategoryCandidateInsertRequest>
    {
        public Instructors_Categories_CandidatesController(ICRUDService<Model.Instructor_Category_Candidate, InstructorCategoryCandidateSearchRequest, InstructorCategoryCandidateInsertRequest, InstructorCategoryCandidateInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
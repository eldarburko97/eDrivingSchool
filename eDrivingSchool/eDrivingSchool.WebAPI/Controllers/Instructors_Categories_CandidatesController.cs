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
    // [Route("api/instructors/{instructorId:int}/categories/{categoryId:int}/candidates")]
    [Route("api/[controller]")]
    [ApiController]
    public class Instructors_Categories_CandidatesController : ControllerBase
    {
        private IInstructorCategoryCandidateService _service;
        public Instructors_Categories_CandidatesController(IInstructorCategoryCandidateService service)
        {
            _service = service;
        }


        [HttpGet]       
        public IList<Model.Instructor_Category_Candidate> GetAll([FromQuery]InstructorCategoryCandidateSearchRequest request)
        {
            return _service.GetAll(request);
        }

        [HttpGet("{instructorId}/{categoryId}/{candidateId}")]
        public Model.Instructor_Category_Candidate GetById(int instructorId, int categoryId, int candidateId)
        {
            return _service.GetById(instructorId, categoryId, candidateId);
        }

        [HttpPost]
        public IActionResult Insert(InstructorCategoryCandidateInsertRequest request)
        {
            try
            {
                return Ok(_service.Insert(request));
            }
            catch (Exception) // vjerovatno je ovog tipa taj exception sto se baci kad je unique constraint violated
            {
                // uhvatis specificni exception koji se baci za constraint
                return BadRequest("Duplicate user"); // ili neki object po potrebi
            }
        }

        [HttpPut("{instructorId}/{categoryId}/{candidateId}")]
        public Model.Instructor_Category_Candidate Update(int instructorId, int categoryId, int candidateId, [FromBody]InstructorCategoryCandidateInsertRequest request)
        {
            return _service.Update(instructorId, categoryId, candidateId, request);
        }



        /*
        private IRepositoryInstructorCategoryCandidate _repository = null;
        public Instructors_Categories_CandidatesController(IRepositoryInstructorCategoryCandidate repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll(InstructorCategoryCandidateApiModel model)
        {
            try
            {
                return Ok(_repository.FindAll(model.InstructorId, model.CategoryId));
            }
            catch
            {
                return StatusCode(500);
            }
        }


        [HttpGet]
        [Route("{candidateId:int}")]
        public IActionResult GetById(int candidateId,InstructorCategoryCandidateApiModel model)
        {
            try
            {
                return Ok(_repository.FindAll(model.InstructorId, model.CategoryId));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] InstructorCategoryCandidateInsertRequest model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        return Ok(_repository.Insert(model));
                    }
                    catch
                    {
                        return StatusCode(500);
                    }

                }
                return BadRequest(ModelState);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        
        instruktor mirso | kategorija b | kandidati eldar, ahmed, test, test1, test 2

            InstructorCategoryCandidate

            foreach(var item in selected){
                payment=new Payment();
        payment.Inst
        */

    }
}

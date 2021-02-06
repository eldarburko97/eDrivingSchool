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
    public class Instructors_CategoriesController : BaseCRUDController<Model.Instructor_Category, InstructorCategorySearchRequest, InstructorCategoryInsertRequest, InstructorCategoryInsertRequest>
    {
        public Instructors_CategoriesController(ICRUDService<Model.Instructor_Category, InstructorCategorySearchRequest, InstructorCategoryInsertRequest, InstructorCategoryInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }

        /*
        [HttpGet]
        public IActionResult Find()
        {

        }
        [HttpGet]
        [Route("{categoryId:int}")]
        public IActionResult FindByCategoryId()
        {

        }
        [HttpPost]
        public IActionResult Post(int instructorId, List<int> categoryId)
        {

        }*/
    }
}

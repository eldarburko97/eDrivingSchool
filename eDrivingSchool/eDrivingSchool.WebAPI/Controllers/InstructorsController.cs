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
    public class InstructorsController : BaseCRUDController<Model.Instructor, InstructorSearchRequest, Model.Requests.InstructorInsertRequest, Model.Requests.InstructorInsertRequest>
    {
        public InstructorsController(ICRUDService<Model.Instructor, InstructorSearchRequest, InstructorInsertRequest, InstructorInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
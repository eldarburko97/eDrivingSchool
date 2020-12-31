using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DrivingSchoolsController : BaseCRUDController<Model.DrivingSchool, object, Model.Requests.DrivingSchoolInsertRequest, Model.Requests.DrivingSchoolInsertRequest>
    {
        public DrivingSchoolsController(ICRUDService<DrivingSchool, object, DrivingSchoolInsertRequest, DrivingSchoolInsertRequest> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
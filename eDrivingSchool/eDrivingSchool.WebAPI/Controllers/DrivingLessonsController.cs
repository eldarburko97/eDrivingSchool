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
    public class DrivingLessonsController : BaseCRUDController<Model.DrivingLesson, DrivingLessonSearchRequest, DrivingLessonInsertRequest, DrivingLessonInsertRequest>
    {
        public DrivingLessonsController(ICRUDService<Model.DrivingLesson, DrivingLessonSearchRequest, DrivingLessonInsertRequest, DrivingLessonInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
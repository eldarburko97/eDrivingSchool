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
    public class Certificate_RequestsController : BaseCRUDController<Model.Certificate_Request, Certificate_RequestSearch, Certificate_RequestInsert, Certificate_RequestInsert>
    {
        public Certificate_RequestsController(ICRUDService<Model.Certificate_Request, Certificate_RequestSearch, Certificate_RequestInsert, Certificate_RequestInsert> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
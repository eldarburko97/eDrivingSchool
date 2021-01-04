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
    public class TheoryTestApplicationsController : BaseCRUDController<Model.TheoryTestApplications, TheoryTestApplicationsSearchRequest, TheoryTestApplicationsInsertRequest, TheoryTestApplicationsInsertRequest>
    {
        public TheoryTestApplicationsController(ICRUDService<Model.TheoryTestApplications, TheoryTestApplicationsSearchRequest, TheoryTestApplicationsInsertRequest, TheoryTestApplicationsInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
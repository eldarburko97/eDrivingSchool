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
    public class ManufacturersController : BaseCRUDController<Model.Manufacturer, ManufacturerSearchRequest, ManufacturerInsertRequest, ManufacturerInsertRequest>
    {
        public ManufacturersController(ICRUDService<Model.Manufacturer, ManufacturerSearchRequest, ManufacturerInsertRequest, ManufacturerInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
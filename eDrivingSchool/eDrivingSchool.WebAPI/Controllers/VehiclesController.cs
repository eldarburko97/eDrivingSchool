using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : BaseCRUDController<Model.Vehicle, Model.Requests.VehicleSearchRequest, Model.Requests.VehicleInsertRequest, Model.Requests.VehicleInsertRequest>
    {
        public VehiclesController(ICRUDService<Vehicle, VehicleSearchRequest, VehicleInsertRequest, VehicleInsertRequest> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
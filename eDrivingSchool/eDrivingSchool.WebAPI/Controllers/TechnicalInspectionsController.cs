using AutoMapper;
using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalInspectionsController : BaseCRUDController<Model.TechnicalInspection, Model.Requests.TechnicalInspectionSearchRequest, Model.Requests.TechnicalInspectionInsertRequest, Model.Requests.TechnicalInspectionInsertRequest>
    {
        public TechnicalInspectionsController(ICRUDService<TechnicalInspection, TechnicalInspectionSearchRequest, TechnicalInspectionInsertRequest, TechnicalInspectionInsertRequest> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}

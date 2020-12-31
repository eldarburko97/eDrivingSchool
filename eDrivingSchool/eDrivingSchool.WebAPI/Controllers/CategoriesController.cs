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
    public class CategoriesController : BaseCRUDController<Model.Category, object, Model.Requests.CategoryInsertRequest, Model.Requests.CategoryInsertRequest>
    {
        public CategoriesController(ICRUDService<Category, object, CategoryInsertRequest, CategoryInsertRequest> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
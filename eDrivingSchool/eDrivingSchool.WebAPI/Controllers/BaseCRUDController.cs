using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : ControllerBase
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        private readonly IMapper _mapper = null;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public List<T> GetAll([FromQuery]TSearch request)
        {
            return _service.GetAll(request);
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public T Update(int id, TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public T Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
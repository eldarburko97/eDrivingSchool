using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eDrivingSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        protected IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        public IList<Model.User> GetAll([FromQuery]UserSearchRequest request)
        {
            return _service.GetAll(request);
        }

        [HttpGet("{id}")]
        [Authorize]
        public Model.User GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost(Name = "insert")]
        public IActionResult Insert(UserInsertRequest korisnici)
        {
            try
            {
                return Ok(_service.Insert(korisnici));
            }
            catch (DbUpdateException) // vjerovatno je ovog tipa taj exception sto se baci kad je unique constraint violated
            {
                // uhvatis specificni exception koji se baci za constraint
                return BadRequest("Duplicate user"); // ili neki object po potrebi
            }
        }

        [HttpPut("{id}")]
        public Model.User Update(int id, [FromBody]UserInsertRequest request)
        {
            return _service.Update(id, request);
        }
        /*
        public Models.Korisnik Login(KorisniciLoginRequest request)
        {
            return _service.Login(request);
        }
        */


        // Ne moze milion akcija s istom rutom nikako
        [HttpPost("{login}")]
        public Model.User Login(UserLoginRequest request)
        {
            return _service.Login(request);
        }

        [HttpPost("register")]
        public Model.User Register(UserInsertRequest request)
        {
            return _service.Register(request);
        }
    }
}
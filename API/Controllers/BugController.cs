using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BugController : BaseApiController
    {
        private readonly DataContext _context;
        public BugController(DataContext context){
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]  // posting client data/ form data to the server
        public ActionResult<string> GetSecret()
        {
            return "Secret text";
        }


        [HttpGet("not-found")]  // posting client data/ form data to the server
        public ActionResult<AppUser> GetNotFound()
        {
            var obj = _context.Users.Find(-1);
            if(obj == null) return NotFound();
            return Ok(obj);
        }


        [HttpGet("server-error")]  // posting client data/ form data to the server
        public ActionResult<string> GetServerError()
        {
            var obj = _context.Users.Find(-1);

            var objToReturn = obj.ToString(); // this will be a null reference and thus a null reference exception

            return objToReturn;
        }


        [HttpGet("bad-request")]  // posting client data/ form data to the server
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("Bad request to the server");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examples.Web.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateUser([FromBody] RegisterUserRequest request)
        {
            //Here you could do some stuff like create the user and that kind of stuff
            return Ok();
        }
    }
}

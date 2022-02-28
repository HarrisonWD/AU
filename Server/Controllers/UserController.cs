using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AU.Shared;
using System;
using System.Collections.Generic;

namespace AU.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> users = new List<User>{
            new User{ FirstName = "Peter", LastName = "Parker", Email = "spiderman@hotmail.co.uk" },
            new User{ FirstName = "Clark", LastName = "Kent", Email = "superman@hotmail.co.uk" },
            new User{ FirstName = "Bruce", LastName = "Banner", Email = "b4tman@hotmail.co.uk" }
        };

        public async Task<IActionResult> GetUsers()
        {
            return Ok(users);
        }
    }
}

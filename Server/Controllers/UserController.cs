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
        List<UserViewModel> users = new List<UserViewModel>{
            new UserViewModel{ FirstName = "Peter", LastName = "Parker", Email = "spiderman@hotmail.co.uk" },
            new UserViewModel{ FirstName = "Clark", LastName = "Kent", Email = "superman@hotmail.co.uk" },
            new UserViewModel{ FirstName = "Bruce", LastName = "Banner", Email = "b4tman@hotmail.co.uk" }
        };

        public async Task<IActionResult> GetUsers()
        {
            return Ok(users);
        }
    }
}

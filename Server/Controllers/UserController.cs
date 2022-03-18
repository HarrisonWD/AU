using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AU.Shared;
using System;
using System.Collections.Generic;
using AU.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AU.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // List<UserViewModel> users = new List<UserViewModel>{
        //     new UserViewModel{ FirstName = "Peter", LastName = "Parker", Email = "spiderman@hotmail.co.uk" },
        //     new UserViewModel{ FirstName = "Clark", LastName = "Kent", Email = "superman@hotmail.co.uk" },
        //     new UserViewModel{ FirstName = "Bruce", LastName = "Banner", Email = "b4tman@hotmail.co.uk" }
        // };

        private readonly ILogger<UserController> _logger;

        private readonly AUContext _context;

        public UserController(ILogger<UserController> logger, AUContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public List<User> Get()
        {
          return _context.Users.ToList();
        }

        [HttpGet("getprofile/{userId}")]
        public async Task<User> GetProfile(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }
        
    }
}

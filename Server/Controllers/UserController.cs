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
            this._logger = logger;
            this._context = context;
        }

        [HttpGet]
        public List<User> Get()
        {
          return _context.Users.ToList();
        }

        [HttpPut("updateprofile/{userId}")]
        public async Task<User> UpdateProfile(int userId, [FromBody] User user)
        {
            User userToUpdate = await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();

            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;

            await _context.SaveChangesAsync();

            return await Task.FromResult(user);
        }


        [HttpGet("getprofile/{userId}")]
        public async Task<User> GetProfile(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }


        [HttpGet("updatetheme")]
        public async Task<User> UpdateTheme(string userId, string value)
        {
            User user = _context.Users.Where(u => u.Id == Convert.ToInt32(userId)).FirstOrDefault();
            user.DarkTheme = value == "True" ? 1 : 0;

            await _context.SaveChangesAsync();

            return await Task.FromResult(user);
        }

        [HttpGet("updatenotifications")]
        public async Task<User> UpdateNotifications(string userId, string value)
        {
            User user = _context.Users.Where(u => u.Id == Convert.ToInt32(userId)).FirstOrDefault();
            user.Notifications = value == "True" ? 1 : 0;

            await _context.SaveChangesAsync();

            return await Task.FromResult(user);
        }
    }
}

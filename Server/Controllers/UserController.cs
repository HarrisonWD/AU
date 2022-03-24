using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AU.Shared;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using AU.Server.Models;
using AU.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;

namespace AU.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> logger;

        private readonly AUContext _context;

        public UserController(ILogger<UserController> logger, AUContext context)
        {
            this.logger = logger;
            this._context = context;
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

        [HttpGet("getcurrentuser")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();

            if (User.Identity.IsAuthenticated)
            {
                currentUser.Email = User.FindFirstValue(ClaimTypes.Name);
            }

            return await Task.FromResult(currentUser);
        }

        [HttpPost("registeruser")]
        public async Task<ActionResult> RegisterUser (User user)
        {
            var emailAddressEsists = _context.Users.Where(u => u.Email == user.Email).FirstOrDefault();
            if (emailAddressEsists == null)
            {
                user.Password = Utility.Encrypt(user.Password);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            user.Password = Utility.Encrypt(user.Password);
            User loggedInUser = await _context.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();

            if (loggedInUser != null)
            {
                //create claims
                var claim = new Claim(ClaimTypes.Name, loggedInUser.Email);
                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claim }, "serverAuth");
                //cerate claims principal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //Sign in the user
                await HttpContext.SignInAsync(claimsPrincipal);
            }
            return await Task.FromResult(loggedInUser);
        }

        [HttpGet("logoutuser")]
        public async Task<ActionResult<String>> LogOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
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

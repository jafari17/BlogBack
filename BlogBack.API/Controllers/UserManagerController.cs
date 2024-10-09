using BlogBack.Domain;
using BlogBack.Infrastructure.DbContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BlogBack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserManagerController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserManagerController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserIdByEmail(string userEmail)
        {
            //var user = await _userManager.FindByIdAsync( ); 
            var user = await _userManager.FindByEmailAsync(userEmail);
             
            if (user == null) { return Ok(); }; 
            return Ok(user.Id);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserEmailById(string idUser)
        {
            //var user = await _userManager.FindByIdAsync( ); 
            var user = await _userManager.FindByIdAsync(idUser);

            if (user == null) { return Ok(); };
            return Ok(user.Email);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserFullNameById(string idUser)
        {
            //var user = await _userManager.FindByIdAsync( ); 
            var user = await _userManager.FindByIdAsync(idUser);

            if (user == null) { return Ok(); };
            return Ok(user.FullName);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserById(string idUser)
        {
            //var user = await _userManager.FindByIdAsync(idUser);

            var uz = await _userManager.Users.Where(u => u.Id == idUser).ToListAsync();





            if (uz == null) { return Ok(); };
            return Ok(uz);
        }
         

        [HttpGet]
        public async Task<IActionResult> Register(string email, string password, string fullName)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Email = email,
                UserName = email,
                FullName = fullName
            };
             var userResult = await _userManager.CreateAsync(user, password );

            if (userResult == null) { return Ok(); };
            return Ok(userResult);
        }
         
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> CheckingLogin()
        {
             return Ok(true);
        }
    }
}

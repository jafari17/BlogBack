using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BlogBack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserManagerController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserManagerController(UserManager<IdentityUser> userManager)
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






        [Authorize]
        [HttpGet]
        public async Task<IActionResult> CheckingLogin()
        {
             return Ok(true);
        }
    }
}

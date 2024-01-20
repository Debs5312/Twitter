using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;    
        }

        [HttpPost("login")] // -> api/user/login
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if(user == null) return Unauthorized();
            var checkPasswd = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if(checkPasswd)
            { 
                var newUSer = new UserDTO 
                {
                    DisplayName = user.DisplayName,
                    Image = null,
                    Token = "This is a token",
                    UserName = user.UserName,
                    Bio = user.Bio
                };
                return Ok(newUSer); 
            }
            return Unauthorized();
        }

    }
}
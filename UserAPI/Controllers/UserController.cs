using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.DTO;
using UserAPI.Services;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly TokenService _tokenService;
        public UserController(UserManager<AppUser> userManager, TokenService tokenService)
        {
            _tokenService = tokenService;
            _userManager = userManager;    
        }

        [AllowAnonymous]
        [HttpPost("login")] // -> api/user/login
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if(user == null) return Unauthorized();
            var checkPasswd = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if(checkPasswd)
            { 
                return Ok(CreateUserObj(user)); 
            }
            return Unauthorized();
        }
    
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            if(await _userManager.Users.AnyAsync(x => x.UserName == registerDTO.UserName))
            {
                return BadRequest("Username is already taken");
            }

            var user = new AppUser
            {
                DisplayName = registerDTO.UserName,
                Email = registerDTO.Email,
                UserName = registerDTO.UserName,
                Bio = registerDTO.Bio
            };

            var result = await _userManager.CreateAsync(user, registerDTO.Password);

            if(result.Succeeded)
            {
                return Ok(CreateUserObj(user));
            }

            return BadRequest(result.Errors);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetCurrentUser()
        {
            var user = await _userManager.FindByEmailAsync(User.FindFirstValue(ClaimTypes.Email));
            return Ok(CreateUserObj(user));
        }

        private UserDTO CreateUserObj(AppUser user)
        {
            return (
                new UserDTO {
                    DisplayName = user.DisplayName,
                    Image = null,
                    Token = _tokenService.CreateToken(user),
                    UserName = user.UserName,
                    Bio = user.Bio
                }
            );
        }

    }
}
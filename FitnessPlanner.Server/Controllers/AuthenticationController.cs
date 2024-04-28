using FitnessPlanner.Services.Authentication.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Server.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController(
        IAuthenticationService authenticationService,
        ILogger<AuthenticationController> logger) : BaseController
    {
        [HttpPost("register")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RegisterUser(UserRegistrationDto model)
        {
            IdentityResult? result;
            try
            {
                result = await authenticationService.RegisterUserAsync(model);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(RegisterUser)}");
                return StatusCode(500, "Internal server error");
            }

            if (result.Succeeded)
            {
                return StatusCode(StatusCodes.Status201Created);
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AuthenticateUser(UserLoginDto model)
        {
            bool isAuthenticated;
            try
            {
                isAuthenticated = await authenticationService.AuthenticateUserAsync(model);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(AuthenticateUser)}");
                return StatusCode(500, "Internal server error");
            }

            if (isAuthenticated)
            {
                var token = await authenticationService.CreateToken();
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }
}

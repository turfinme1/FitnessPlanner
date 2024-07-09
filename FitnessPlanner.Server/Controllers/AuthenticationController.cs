using FitnessPlanner.Server.Models;
using FitnessPlanner.Services.Authentication.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to authentication,
    /// such as user registration and login.
    /// </summary>
    /// <param name="authenticationService">Service for handling authentication operations.</param>
    /// <param name="logger">Logger for logging information and errors.</param>
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController(
        IAuthenticationService authenticationService,
        ILogger<AuthenticationController> logger) : BaseController
    {
        /// <summary>
        /// Registers a new user in the system.
        /// </summary>
        /// <param name="model">The user registration data transfer object containing the user's details.</param>
        /// <returns>
        /// A status code indicating the result of the operation. If successful, returns 201 (Created).
        /// </returns>
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

            var response = new ErrorResponse
            {
                Title = "Bad request",
                Status = StatusCodes.Status400BadRequest,
                ErrorMessage = "Could not register user with provided data."
            };
            return BadRequest(response);
        }

        /// <summary>
        /// Authenticates a user and generates a JWT token if the authentication is successful.
        /// </summary>
        /// <param name="model">The user login data transfer object containing the user's login credentials.</param>
        /// <returns> 
        /// A status code indicating the result of the operation. If the user was successfully authenticated, returns 200 (OK) with a JWT token.
        /// </returns>
        /// <returns>Failed login</returns>
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

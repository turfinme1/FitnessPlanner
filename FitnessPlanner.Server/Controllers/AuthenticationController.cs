using FitnessPlanner.Server.Extensions;
using FitnessPlanner.Server.Models;
using FitnessPlanner.Services.Authentication.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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
        /// <response code="200">If the user was successfully registered.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPost("register")]
        [AllowAnonymous]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RegisterUser(UserRegistrationDto model) =>
            (await authenticationService.RegisterUserAsync(model)).ToActionResult();

        /// <summary>
        /// Authenticates a user and generates a JWT token if the authentication is successful.
        /// </summary>
        /// <param name="model">The user login data transfer object containing the user's login credentials.</param>
        /// <returns> 
        /// A status code indicating the result of the operation. If the user was successfully authenticated, returns 200 (OK) with a JWT token.
        /// </returns>
        /// <response code="200">If the user was successfully authenticated.</response>
        /// <response code="401">If the user could not be authenticated.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPost("login")]
        [AllowAnonymous]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AuthenticateUser(UserLoginDto model) =>
            (await authenticationService.AuthenticateUserAsync(model)).ToActionResult();
    }
}

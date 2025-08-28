using FitnessPlanner.Server.Extensions;
using FitnessPlanner.Server.Models;
using FitnessPlanner.Services.Admin.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to admin.
    /// </summary>
    /// <param name="adminService">Service for handling admin operations.</param>
    /// <param name="logger">Logger for logging information and errors.</param>
    [ApiController]
    [Route("api/admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController(
        IAdminService adminService,
        ILogger<AdminController> logger) : BaseController
    {
        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>A collection of <see cref="UserDisplayDto"/> objects representing all users.</returns>
        /// <response code="200">Returns the collection of users.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="403">If the user is not authorized.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet("users")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<UserDisplayDto>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllUsers() =>
            (await adminService.GetAllUsersAsync()).ToActionResult();
    }
}

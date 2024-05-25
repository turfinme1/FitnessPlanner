using FitnessPlanner.Services.Admin.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to admin.
    /// </summary>
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
        [HttpGet("users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<UserDisplayDto>>> GetAllUsers()
        {
            try
            {
                return Ok(await adminService.GetAllUsersAsync());
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllUsers)}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

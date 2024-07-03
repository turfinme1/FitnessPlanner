using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Abstract base controller class with authorization attribute.
    /// </summary>
    [Authorize]
    public abstract class BaseController : ControllerBase
    {
    }
}

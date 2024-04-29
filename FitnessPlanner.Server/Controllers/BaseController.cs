using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Server.Controllers
{
    [Authorize]
    public abstract class BaseController : ControllerBase
    {
    }
}

using Ardalis.Result;
using FitnessPlanner.Server.Models;
using Microsoft.AspNetCore.Mvc;
using IResult = Ardalis.Result.IResult;

namespace FitnessPlanner.Server.Extensions
{
    public static class ResultExtensions
    {
        public static IActionResult ToActionResult(this Result result)
        {
            return result.IsSuccess
                ? new OkResult()
                : result.ToNonSuccessActionResult();
        }

        public static IActionResult ToActionResult<T>(this Result<T> result)
        {
            return result.IsSuccess
                ? new OkObjectResult(ApiResponse<T>.Ok(result.Value))
                : result.ToNonSuccessActionResult();
        }

        private static IActionResult ToNonSuccessActionResult(this IResult result)
        {
            return result.Status switch
            {
                ResultStatus.Unauthorized => new UnauthorizedObjectResult(ApiResponse.Unauthorized()),
                ResultStatus.NotFound => new NotFoundObjectResult(ApiResponse.NotFound()),
                _ => new BadRequestObjectResult(ApiResponse.BadRequest())
            };
        }
    }
}

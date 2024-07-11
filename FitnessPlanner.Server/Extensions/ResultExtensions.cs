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
                ? new OkObjectResult(ApiResponse.Ok())
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
            var error = result.Errors.ToList().FirstOrDefault();

            return result.Status switch
            {
                ResultStatus.Unauthorized => new UnauthorizedObjectResult(ApiResponse.Unauthorized()),
                ResultStatus.NotFound => error is null
                    ? new NotFoundObjectResult(ApiResponse.NotFound())
                    : new NotFoundObjectResult(ApiResponse.NotFound(error)),
                _ => error is null
                    ? new BadRequestObjectResult(ApiResponse.BadRequest())
                    : new BadRequestObjectResult(ApiResponse.BadRequest(error))
            };
        }
    }
}

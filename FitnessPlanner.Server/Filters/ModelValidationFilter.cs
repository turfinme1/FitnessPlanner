using FitnessPlanner.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FitnessPlanner.Server.Filters
{

    public class ModelValidationFilter : IActionFilter
    {
        /// <inheritdoc />
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var response = new UnprocessableEntityResponse
                {
                    Title = "One or more validation errors occurred.",
                    Status = StatusCodes.Status422UnprocessableEntity,
                    Errors = new Dictionary<string, string[]>()
                };

                foreach (var errors in context.ModelState.Where(s => s.Key != "model"))
                {
                    var key = errors.Key.Replace("$.", "");
                    var errorMessages = errors.Value?.Errors.Select(e => e.ErrorMessage)
                         .Select(str => str.Contains("The JSON value could not be converted") ? "The value could not be processed" : str)
                         .ToArray();

                    if (errorMessages is not null)
                    {
                        response.Errors.Add(key, errorMessages);
                    }
                }

                context.Result = new UnprocessableEntityObjectResult(response);
            }
        }

        /// <inheritdoc />
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}

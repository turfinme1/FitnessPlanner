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
                var errors = new Dictionary<string, string[]>();
                foreach (var keyValuePair in context.ModelState.Where(s => s.Key != "model"))
                {
                    var key = keyValuePair.Key.Replace("$.", "");
                    var errorMessages = keyValuePair.Value?.Errors
                        .Select(e => e.ErrorMessage)
                        .Select(str =>
                        {
                            if (str.Contains("The JSON value could not be converted") || str.Contains("invalid"))
                            {
                                return "The value is invalid.";
                            }
                            return str;
                        })
                        .ToArray();

                    if (errorMessages is not null)
                    {
                        errors.Add(key, errorMessages);
                    }
                }

                var response = ApiResponse.Unprocessable(errors);
                context.Result = new UnprocessableEntityObjectResult(response);
            }
        }

        /// <inheritdoc />
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}

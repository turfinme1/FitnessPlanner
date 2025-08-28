using System.Text.Json.Serialization;

namespace FitnessPlanner.Server.Models
{
    public class ApiResponse
    {
        public ApiResponse(string title, bool success, string message, int statusCode, IDictionary<string, string[]> errors)
        {
            Title = title;
            Success = success;
            Message = message;
            StatusCode = statusCode;
            Errors = errors;
        }

        public ApiResponse()
        {
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Title { get; protected init; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Success { get; protected init; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; protected init; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? StatusCode { get; protected init; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IDictionary<string, string[]>? Errors { get; private init; }

        public static ApiResponse Ok() =>
            new() { Title = "Ok", Success = true, StatusCode = StatusCodes.Status200OK };

        public static ApiResponse Ok(string successMessage) =>
            new() { Title = "Ok", Success = true, StatusCode = StatusCodes.Status200OK, Message = successMessage };

        public static ApiResponse BadRequest() =>
            new() { Title = "Bad request", Success = false, StatusCode = StatusCodes.Status400BadRequest };

        public static ApiResponse BadRequest(string errorMessage) =>
            new() { Title = "Bad request", Success = false, StatusCode = StatusCodes.Status400BadRequest, Message = errorMessage };

        public static ApiResponse BadRequest(IDictionary<string, string[]> errors) =>
            new() { Title = "Bad request", Success = false, StatusCode = StatusCodes.Status400BadRequest, Errors = errors };

        public static ApiResponse Unauthorized() =>
            new() { Title = "Unauthorized", Success = false, StatusCode = StatusCodes.Status401Unauthorized };

        public static ApiResponse Unauthorized(string errorMessage) =>
            new() { Title = "Unauthorized", Success = false, StatusCode = StatusCodes.Status401Unauthorized, Message = errorMessage };

        public static ApiResponse Unauthorized(IDictionary<string, string[]> errors) =>
            new() { Title = "Unauthorized", Success = false, StatusCode = StatusCodes.Status401Unauthorized, Errors = errors };

        public static ApiResponse Forbidden() =>
            new() { Title = "Forbidden", Success = false, StatusCode = StatusCodes.Status403Forbidden };

        public static ApiResponse Forbidden(string errorMessage) =>
            new() { Title = "Forbidden", Success = false, StatusCode = StatusCodes.Status403Forbidden, Message = errorMessage };

        public static ApiResponse Forbidden(IDictionary<string, string[]> errors) =>
            new() { Title = "Forbidden", Success = false, StatusCode = StatusCodes.Status403Forbidden, Errors = errors };

        public static ApiResponse NotFound() =>
            new() { Title = "Not Found", Success = false, StatusCode = StatusCodes.Status404NotFound };

        public static ApiResponse NotFound(string errorMessage) =>
            new() { Title = "Not Found", Success = false, StatusCode = StatusCodes.Status404NotFound, Message = errorMessage };

        public static ApiResponse NotFound(IDictionary<string, string[]> errors) =>
            new() { Title = "Not Found", Success = false, StatusCode = StatusCodes.Status404NotFound, Errors = errors };

        public static ApiResponse Unprocessable() =>
            new() { Title = "Unprocessable Content", Success = false, StatusCode = StatusCodes.Status422UnprocessableEntity };

        public static ApiResponse Unprocessable(string errorMessage) =>
            new() { Title = "Unprocessable Content", Success = false, StatusCode = StatusCodes.Status422UnprocessableEntity, Message = errorMessage };

        public static ApiResponse Unprocessable(IDictionary<string, string[]> errors) =>
            new() { Title = "Unprocessable Content", Success = false, StatusCode = StatusCodes.Status422UnprocessableEntity, Errors = errors };

        public static ApiResponse InternalServerError(string errorMessage) =>
            new() { Title = "Internal Server Error", Success = false, StatusCode = StatusCodes.Status500InternalServerError, Message = errorMessage };

        public static ApiResponse InternalServerError(IDictionary<string, string[]> errors) =>
            new() { Title = "Internal Server Error", Success = false, StatusCode = StatusCodes.Status500InternalServerError, Errors = errors };

        private static IDictionary<string, string[]> CreateErrors(string errorMessage)
        {
            return new Dictionary<string, string[]>
            {
                { "Internal Error", new[] { errorMessage } }
            };
        }
    }
}


namespace FitnessPlanner.Server.Models
{
    public sealed class ApiResponse<T> : ApiResponse
    {
        public ApiResponse(T result, string title, bool success, string message, int statusCode, IDictionary<string, string[]> errors)
            :base(title, success, message, statusCode, errors)
        {
            Result = result;
        }

        public ApiResponse()
        {
        }

        public T Result { get; private init; }

        public static ApiResponse<T> Ok(T result) =>
            new() { Title = "Ok", Success = true, StatusCode = StatusCodes.Status200OK, Result = result };

        public static ApiResponse<T> Ok(T result, string successMessage) =>
            new() { Title = "Ok", Success = true, StatusCode = StatusCodes.Status200OK, Message = successMessage, Result = result};
    }
}

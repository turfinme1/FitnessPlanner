namespace FitnessPlanner.Server.Models
{
    public class ErrorResponse
    {
        public required string Title { get; init; }

        public required int Status { get; init; }

        public required string ErrorMessage { get; init; }
    }
}

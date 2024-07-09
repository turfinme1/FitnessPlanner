namespace FitnessPlanner.Server.Models
{
    public class UnprocessableEntityResponse
    {
        public required string Title { get; init; }

        public required int Status { get; init; }

        public IDictionary<string, string[]> Errors { get; init; } = new Dictionary<string, string[]>();
    }
}

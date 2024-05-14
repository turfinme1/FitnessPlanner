namespace FitnessPlanner.Services.Models.User
{
    public class UserDisplayDto
    {
        public string Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Gender { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public required string SkillLevel { get; set; }

        public required string Goal { get; set; }

        public required string BodyMassIndexMeasure { get; set; }
    }
}

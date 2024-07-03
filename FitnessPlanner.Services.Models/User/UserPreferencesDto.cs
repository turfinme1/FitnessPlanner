namespace FitnessPlanner.Services.Models.User
{
    public class UserPreferencesDto
    {
        public required string Id { get; set; }

        public required string Goal { get; set; }

        public required string SkillLevel { get; set; }

        public required string BodyMassIndexMeasures { get; set; }
    }
}

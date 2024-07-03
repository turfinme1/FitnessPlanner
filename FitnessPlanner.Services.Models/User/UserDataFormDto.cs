namespace FitnessPlanner.Services.Models.User
{
    public class UserDataFormDto
    {
        public required string Name { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public int SkillLevelId { get; set; }

        public int GoalId { get; set; }
    }
}

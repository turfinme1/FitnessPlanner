namespace FitnessPlanner.Data.Models.Constants
{
    public static class ValidationConstants
    {
        public static class MuscleGroupConstants
        {
            public const int NameMaxLength = 50;
        }

        public static class ExerciseConstants
        {
            public const int NameMaxLength = 50;
            public const int ExplanationMaxLength = 500;
            public const int PerformTipMaxLength = 500;
            public const int ImageNameMaxLength = 100;
        }

        public static class SingleWorkoutConstants
        {
            public const int NameMaxLength = 50;
        }

        public static class WorkoutPlanConstants
        {
            public const int NameMaxLength = 50;
            public const int UserIdMaxLength = 450;
        }

        public static class UserConstants
        {
            public const int NameMaxLength = 100;
            public const int UserIdMaxLength = 450;
        }
    }
}

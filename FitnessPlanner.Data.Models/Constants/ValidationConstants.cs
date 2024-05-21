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
            public const int ExplanationMaxLength = 2000;
            public const int PerformTipMaxLength = 2000;
            public const int ImageNameMaxLength = 100;
        }

        public static class SingleWorkoutConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class WorkoutPlanConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
            public const int UserIdMaxLength = 450;
        }

        public static class UserConstants
        {
            public const int UserIdMaxLength = 450;

            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
            
            public const int AgeMinLength = 14;
            public const int AgeMaxLength = 99;

            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 30;

            public const int EmailMinLength = 5;
            public const int EmailMaxLength = 50;

            public const int HeightMinLength = 80;
            public const int HeightMaxLength = 250;

            public const int WeightMinLength = 30;
            public const int WeightMaxLength = 200;
        }

        public static class ExercisePerformInfoConstants
        {
            public const int SetsMinValue = 1;
            public const int SetsMaxValue = 10;

            public const int RepsMinValue = 1;
            public const int RepsMaxValue = 50;
        }

        public static class GoalConstants
        {
            public const int GoalNameMaxLength = 50;
            public const int GoalNameMinLength = 3;
            public const int GoalIdMinRange = 1;
            public const int GoalIdMaxRange = 3;
        }

        public static class SkillLevelConstants
        {
            public const int SkillNameMaxLength = 50;
            public const int SkillNameMinLength = 3;
            public const int SkillIdMinRange = 1;
            public const int SkillIdMaxRange = 4;
        }

        public static class BodyMassIndexMeasureConstants
        {
            public const int TypeMaxLength = 50;
            public const int TypeMinLength = 3;
        }

        public static class ErrorMessages
        {
            public const string RequiredErrorMessage = "The field {0} is required.";
            public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters.";
            public const string RangeErrorMessage = "The {0} must be between {1} and {2}.";
        }
    }
}

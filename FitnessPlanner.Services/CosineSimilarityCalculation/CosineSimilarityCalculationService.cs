using Ardalis.Result;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.BodyMassIndexMeasure.Contracts;
using FitnessPlanner.Services.CosineSimilarityCalculation.Contracts;
using FitnessPlanner.Services.Goal.Contracts;
using FitnessPlanner.Services.Models.User;
using FitnessPlanner.Services.Models.WorkoutPlan;
using FitnessPlanner.Services.SkillLevel.Contracts;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.CosineSimilarityCalculation
{
    public class CosineSimilarityCalculationService(
        IGoalService goalService,
        ISkillLevelService skillLevelService,
        IBodyMassIndexMeasureService bodyMassIndexService,
        IUserService userService,
        IWorkoutPlanService workoutService,
        ILogger<CosineSimilarityCalculationService> logger) : ICosineSimilarityCalculationService
    {
        public async Task<Result<WorkoutPlanDisplayDto>> GetWorkoutIdRecommendationByUserIdAsync(string? userId)
        {
            UserPreferencesDto? user;
            IEnumerable<WorkoutPlanPropertiesDto> workoutPlan;
            ICollection<string> vocabulary;

            if (userId is null)
            {
                return Result.Error($"User Id not provided.");
            }

            try
            {
                var result = await userService.GetByIdAsUserPreferenceDtoAsync(userId);
                if (!result.IsSuccess)
                {
                    return Result.Error($"User with Id: {userId} doesn't exist.");
                }

                user = result.Value;

                var workoutPlanResult = await workoutService.GetAllWorkoutsWithPreferencesAsync();
                if (!workoutPlanResult.IsSuccess)
                {
                    return Result.Error($"Couldn't retrieve workout plans.");
                }

                workoutPlan = workoutPlanResult.Value;
                vocabulary = await GetVocabulary();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetWorkoutIdRecommendationByUserIdAsync)}");
                throw;
            }

            var userVector = BuildVector(vocabulary, user.Goal, user.SkillLevel, new List<string>() { user.BodyMassIndexMeasures });

            Dictionary<int, decimal> similarities = new Dictionary<int, decimal>();
            foreach (var workout in workoutPlan)
            {
                var workoutVector = BuildVector(vocabulary, workout.Goal, workout.SkillLevel, new List<string>(workout.BodyMassIndexMeasures));

                decimal similarity = CalculateCosineSimilarity(userVector, workoutVector);

                similarities.Add(workout.Id, similarity);
            }

            var maxSimilarity = similarities.OrderByDescending(x => x.Value).FirstOrDefault();

            try
            {
                var recommenderWorkout = await workoutService.GetByIdAsync(maxSimilarity.Key);

                if (recommenderWorkout is null)
                {
                    return Result.Error($"Couldn't retrieve recommended workout with Id: {maxSimilarity.Key}");
                }

                return Result<WorkoutPlanDisplayDto>.Success(recommenderWorkout);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetWorkoutIdRecommendationByUserIdAsync)}");
                throw;
            }
        }

        private decimal CalculateCosineSimilarity(decimal[] userVector, decimal[] workoutVector)
        {
            decimal dotProduct = DotProduct(userVector, workoutVector);
            decimal magnitudeA = (decimal)Magnitude(userVector);
            decimal magnitudeB = (decimal)Magnitude(workoutVector);

            decimal cosineSimilarity = dotProduct / (magnitudeA * magnitudeB);

            return cosineSimilarity;
        }

        private async Task<ICollection<string>> GetVocabulary()
        {
            try
            {
                var goalVocabulary = await goalService.GetAllNamesAsync();
                var skillVocabulary = await skillLevelService.GetAllNamesAsync();
                var bodyMassIndexVocabulary = await bodyMassIndexService.GetAllNamesAsync();

                var vocabulary = goalVocabulary.Concat(skillVocabulary).Concat(bodyMassIndexVocabulary).ToList();
                return vocabulary;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetVocabulary)}");
                throw;
            }
        }

        private static decimal[] BuildVector(ICollection<string> vocabulary, string goal, string skill, ICollection<string> bodyMassIndex)
        {
            var vector = new decimal[vocabulary.Count()];

            for (int i = 0; i < vocabulary.Count(); i++)
            {
                var vocabularyElement = vocabulary.ElementAt(i);
                if (vocabularyElement == goal
                    || vocabularyElement == skill
                    || bodyMassIndex.Contains(vocabularyElement))
                {
                    vector[i] = 1;
                }
                else
                {
                    vector[i] = 0;
                }
            }
            return vector;
        }

        private static decimal DotProduct(decimal[] vectorA, decimal[] vectorB)
        {
            decimal dotProduct = 0;
            for (int i = 0; i < vectorA.Length; i++)
            {
                dotProduct += (vectorA[i] * vectorB[i]);
            }
            return dotProduct;
        }

        private static double Magnitude(decimal[] vector)
        {
            double sumOfSquares = 0;
            foreach (var value in vector)
            {
                sumOfSquares += Math.Pow((double)value, 2);
            }
            return Math.Sqrt(sumOfSquares);
        }
    }
}

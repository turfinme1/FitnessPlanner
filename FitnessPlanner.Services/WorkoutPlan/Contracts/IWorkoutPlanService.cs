﻿using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Services.WorkoutPlan.Contracts
{
    public interface IWorkoutPlanService
    {
        Task<IEnumerable<WorkoutPlanDto>> GetAllAsync();

        Task<IEnumerable<WorkoutPlanPropertiesDto>> GetAllWorkoutsWithPreferencesAsync();
        
        Task<WorkoutPlanDto?> GetByIdAsync(int id);

        Task<WorkoutPlanDeleteDto?> GetByIdAsDeleteDtoAsync(int id);

        Task<int> CreateAsync(WorkoutPlanCreateDto model);

        Task UpdateAsync(WorkoutPlanUpdateDto model);

        Task DeleteAsync(int id);
    }
}

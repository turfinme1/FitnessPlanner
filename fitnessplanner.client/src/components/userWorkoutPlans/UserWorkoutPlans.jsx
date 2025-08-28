// fitnessplanner.client/src/components/userWorkoutPlans/UserWorkoutPlans.jsx
import { useEffect, useState } from "react";
import Section from "../section/Section";
import WorkoutCard from "../workoutPlans/workoutCard/WorkoutCard";
import { getUserWorkoutPlans, removeWorkoutPlan } from "../../services/userService";

const UserWorkoutPlans = () => {
  const [workoutPlans, setWorkoutPlans] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    loadWorkoutPlans();
  }, []);

  const loadWorkoutPlans = async () => {
    try {
      const data = await getUserWorkoutPlans();
      setWorkoutPlans(data);
    } catch (error) {
      console.error("Error loading workout plans:", error);
    } finally {
      setIsLoading(false);
    }
  };

  const handleRemove = async (workoutPlanId) => {
    try {
      const success = await removeWorkoutPlan(workoutPlanId);
      if (success) {
        await loadWorkoutPlans(); // Reload the list
      }
    } catch (error) {
      console.error("Error removing workout plan:", error);
    }
  };

  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] h-full w-full p-12"
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="user-workout-list"
    >
      <div>
        <h1 className="text-center h1">My Workout Plans</h1>
        
        {isLoading && (
              <div className="flex justify-center items-center min-h-screen">
                <div className="animate-spin rounded-full h-12 w-12 border-t-2 border-b-2 border-purple-500"></div>
              </div>
        )}
            
        {workoutPlans.length === 0 && (
          <div className="text-center text-gray-500 dark:text-gray-400">
            No workout plans added yet
            </div>
        )}
      </div>
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4 items-center justify-items-center">
        {workoutPlans.map((workoutPlan, index) => (
          <div key={workoutPlan.id} className="relative">
            <WorkoutCard
              img={index}
              id={workoutPlan.id}
              name={workoutPlan.name}
              goal={workoutPlan.goal}
              skillLevel={workoutPlan.skillLevel}
            />
            <button
              onClick={() => handleRemove(workoutPlan.id)}
              className="absolute top-2 right-2 bg-red-500 text-white p-2 rounded-full hover:bg-red-600"
            >
              <svg className="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M6 18L18 6M6 6l12 12" />
              </svg>
            </button>
          </div>
        ))}
      </div>
    </Section>
  );
};

export default UserWorkoutPlans;
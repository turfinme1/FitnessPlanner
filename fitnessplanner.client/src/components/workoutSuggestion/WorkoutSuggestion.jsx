import Button from "../button/Button";
import Section from "../section/Section";
import WorkoutDetails from "../workoutDetails/workoutDetails";
import { getWorkoutSuggestions } from "../../services/workoutService";
import { useNavigate } from "react-router-dom";
import { useState } from "react";
import { addWorkoutToUserProfile } from "../../services/userService";

const WorkoutSuggestion = () => {
  const navigate = useNavigate();
  const [workouts, setWorkouts] = useState([]);
  const [selectedWorkout, setSelectedWorkout] = useState(null);
  const [addingWorkoutId, setAddingWorkoutId] = useState(null);

  const onGetSuggestions = async () => {
    const suggestions = await getWorkoutSuggestions();
    setWorkouts(suggestions);
    setSelectedWorkout(null);
  };

  const handleAddToProfile = async (e, workoutId) => {
    e.stopPropagation(); // Prevent card click event
    setAddingWorkoutId(workoutId);
    try {
      const success = await addWorkoutToUserProfile(workoutId);
      if (success) {
        alert("Workout added to your profile!");
      }
    } catch (error) {
      alert("Failed to add workout to profile");
    } finally {
      setAddingWorkoutId(null);
    }
  };

  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] h-full w-full p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="workout-list"
    >
      <section className="text-center flex flex-col min-h-screen">
        <div>
          <h1 className="text-center h1">Get a workout suggestion</h1>
        </div>
        <div className="text-center">
          <Button onClick={onGetSuggestions} className="">
            Get Suggestion
          </Button>
        </div>
        {/* {workout?.id && <WorkoutDetails workoutData={workout} />} */}

        {workouts.length > 0 && !selectedWorkout && (
          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
            {workouts.map((suggestion) => (
              <div 
                key={suggestion.workoutPlan.id}
                className="bg-gray-800 rounded-lg p-6 cursor-pointer hover:bg-gray-700 transition-colors"
                onClick={() => setSelectedWorkout(suggestion)}
              >
                <h2 className="text-xl font-bold text-white mb-2">
                  {suggestion.workoutPlan.name}
                </h2>
                <div className="text-gray-300 mb-4">
                  <p>Goal: {suggestion.workoutPlan.goal}</p>
                  <p>Level: {suggestion.workoutPlan.skillLevel}</p>
                </div>
                <div className="flex items-center justify-between">
                  <div className="bg-purple-600 rounded-full px-3 py-1">
                    Match Score: {(suggestion.similarityScore * 100).toFixed(1)}%
                  </div>
                  <button
                    onClick={(e) => handleAddToProfile(e, suggestion.workoutPlan.id)}
                    disabled={addingWorkoutId === suggestion.workoutPlan.id}
                    className={`ml-2 px-3 py-1 rounded-full text-sm font-medium
                      ${addingWorkoutId === suggestion.workoutPlan.id
                        ? 'bg-gray-600 cursor-not-allowed'
                        : 'bg-green-600 hover:bg-green-700'}`}
                  >
                    {addingWorkoutId === suggestion.workoutPlan.id 
                      ? 'Adding...' 
                      : 'Add to Profile'}
                  </button>
                </div>
              </div>
            ))}
          </div>
        )}

        {selectedWorkout && (
          <div>
            <button 
              onClick={() => setSelectedWorkout(null)}
              className="mb-4 text-white hover:text-gray-300"
            >
              ← Back to suggestions
            </button>
            <WorkoutDetails providedWorkoutId={selectedWorkout.workoutPlan.id} />
          </div>
        )}

      </section>
    </Section>
  );
};

export default WorkoutSuggestion;

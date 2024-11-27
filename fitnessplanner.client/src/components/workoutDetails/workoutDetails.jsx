import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import SingleWorkoutCard from "./singleWorkoutCard/SingleWorkoutCard";
import { getWorkoutById } from "../../services/workoutService";

const WorkoutDetails = ({ providedWorkoutId }) => {
  const { workoutId } = useParams();
  const [workout, setWorkout] = useState(null);

  useEffect(() => {
    if (providedWorkoutId) {
      getWorkoutById(providedWorkoutId).then((data) => {
        setWorkout(data);
      });
    } else {
      getWorkoutById(workoutId).then((data) => {
        setWorkout(data);
      });
    }
  }, [workoutId]);

  if (!workout) {
    return <div className="text-white text-center">Loading...</div>;
  }

  return (
    <div className="container mx-auto px-4 py-8">
      {/* Workout Plan Header */}
      <div className="bg-gray-800 rounded-lg p-6 mb-8">
        <h1 className="text-4xl font-bold text-white mb-4">{workout.name}</h1>
        <div className="flex gap-4 text-gray-300">
          <span className="bg-gray-700 px-3 py-1 rounded-full">
            Goal: {workout.goal}
          </span>
          <span className="bg-gray-700 px-3 py-1 rounded-full">
            Level: {workout.skillLevel}
          </span>
        </div>
      </div>

      {/* Workout Days */}
      <div className="grid gap-8 md:grid-cols-2 lg:grid-cols-3">
        {workout.workouts.map((workoutDay) => (
          <div
            key={workoutDay.id}
            className="bg-gray-800 rounded-lg shadow-lg overflow-hidden"
          >
            <div className="p-6">
              <h2 className="text-2xl font-bold text-white mb-2">
                Day {workoutDay.day}: {workoutDay.name}
              </h2>
              <div className="space-y-4">
                {workoutDay.exercises.map((exercise) => (
                  <div key={exercise.id} className="bg-gray-700 rounded-lg p-4">
                    <div className="flex justify-between items-center mb-2">
                      <h3 className="text-xl font-medium text-white">
                        {exercise.exerciseName}
                      </h3>
                      <span className="text-gray-300">
                        {exercise.sets} × {exercise.reps}
                      </span>
                    </div>
                    <div className="aspect-w-16 aspect-h-9">
                      <img
                        src={`https://artshopimgs.blob.core.windows.net/images/${exercise.exerciseName.replace(
                          /\s+/g,
                          ""
                        )}.gif`}
                        alt={exercise.exerciseName}
                        className="w-full h-full object-cover rounded-lg"
                      />
                    </div>
                  </div>
                ))}
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default WorkoutDetails;

const workout1 = {
  id: 1,
  name: "Beginner muscle gain full body workout plan",
  goal: "Gain muscle",
  skillLevel: "Beginner",
  workouts: [
    {
      id: 1,
      name: "Full Body type A",
      day: 1,
      exercises: [
        {
          id: 1,
          exerciseName: "Barbell Squat",
          reps: 5,
          sets: 3,
        },
        {
          id: 2,
          exerciseName: "Barbell Bench Press",
          reps: 5,
          sets: 3,
        },
        {
          id: 3,
          exerciseName: "Barbell Bent Over Row",
          reps: 5,
          sets: 3,
        },
        {
          id: 4,
          exerciseName: "Triceps Dips",
          reps: 5,
          sets: 3,
        },
      ],
    },
    {
      id: 2,
      name: "Full Body type B",
      day: 3,
      exercises: [
        {
          id: 1,
          exerciseName: "Barbell Squat",
          reps: 5,
          sets: 3,
        },
        {
          id: 5,
          exerciseName: "Barbell Military Press",
          reps: 5,
          sets: 3,
        },
        {
          id: 6,
          exerciseName: "Bench Dips on Floor",
          reps: 5,
          sets: 3,
        },
        {
          id: 7,
          exerciseName: "Preacher Curl",
          reps: 5,
          sets: 3,
        },
      ],
    },
    {
      id: 3,
      name: "Full Body type A",
      day: 5,
      exercises: [
        {
          id: 1,
          exerciseName: "Barbell Squat",
          reps: 5,
          sets: 3,
        },
        {
          id: 2,
          exerciseName: "Barbell Bench Press",
          reps: 5,
          sets: 3,
        },
        {
          id: 3,
          exerciseName: "Barbell Bent Over Row",
          reps: 5,
          sets: 3,
        },
        {
          id: 4,
          exerciseName: "Triceps Dips",
          reps: 5,
          sets: 3,
        },
      ],
    },
  ],
};

import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import SingleWorkoutCard from "./singleWorkoutCard/SingleWorkoutCard";
import { getWorkoutById } from "../../services/workoutService";

const WorkoutDetails = () => {
  const { workoutId } = useParams();
  const [workout, setWorkout] = useState(workout1);

  useEffect(() => {
    console.log("Workout ID: ", workoutId);

    getWorkoutById(workoutId).then((data) => {
      setWorkout(data);
    });
  }, []);

  return (
    <div className="w-full text-center rounded-lg shadow sm:p-3 bg-gray-800 border-gray-700">
      <div className="flex flex-col justify-center">
        <h5 className="mb-2 text-3xl font-bold text-white">
          {workout.name || "Full Body type A"}
        </h5>
      </div>
      {workout.workouts.map((workout) => (
        <SingleWorkoutCard
          key={workout.id}
          id={workout.id}
          name={workout.name}
          day={workout.day}
          exercises={workout.exercises}
        />
      ))}
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

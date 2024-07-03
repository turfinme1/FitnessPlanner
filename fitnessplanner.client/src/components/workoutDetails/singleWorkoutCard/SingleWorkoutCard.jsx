import ExerciseCard from "../exerciseCard/ExerciseCard";

const SingleWorkoutCard = ({ id, name, day, exercises }) => {
  return (
    <div className="w-full text-center rounded-lg shadow sm:p-3 dark:bg-gray-800 dark:border-gray-700 bg-gray-800 border-gray-700">
      <div className="flex flex-col justify-center">
        <h5 className="mb-2 text-3xl font-bold text-white">
          {`${name} routine`}
        </h5>
        <h5 className="mb-2 text-3xl font-bold text-white">
          {`Day ${day}`}
        </h5>
      </div>
      {exercises.map((exercise) => (
        <ExerciseCard
          id={exercise.id}
          key={exercise.id}
          exerciseName={exercise.exerciseName}
          reps={exercise.reps}
          sets={exercise.sets}
        />
      ))}
    </div>
  );
};

export default SingleWorkoutCard;

import React, { useEffect, useState } from "react";
import { get, useFieldArray, useForm } from "react-hook-form";
import { getExercises } from "../../services/exerciseService";
import { createWorkoutPlan } from "../../services/workoutService";
import { useNavigate } from "react-router-dom";
const CreateWorkout2 = () => {
  const [exercises, setExercises] = useState([]);
  const navigate = useNavigate();
  useEffect(() => {
    getExercises()
      .then((data) => setExercises(data))
      .catch((err) => console.error(err));
  }, []);

  const { register, control, handleSubmit, reset } = useForm({
    defaultValues: {
      name: "",
      userId: "",
      skillLevelId: 1,
      goalId: 1,
      singleWorkouts: [
        {
          name: "",
          day: "",
          exercisePerformInfos: [{ exerciseId: "", sets: "", reps: "" }],
        },
      ],
      bodyMassIndexMeasures: [2],
    },
  });

  const { fields, append, remove } = useFieldArray({
    control,
    name: "singleWorkouts",
  });

  const onSubmit = async (data) => {
    data.userId = JSON.parse(
      sessionStorage.getItem("authData")
    ).state.userData.nameidentifier;
    data.singleWorkouts.map((workout) => {
        workout.day = parseInt(workout.day);
    });
    await createWorkoutPlan(data);
    navigate("/workout-list");
    console.log(data);
    reset({
      singleWorkouts: [
        {
          name: "",
          day: "",
          exercisePerformInfos: [{ exerciseId: "", sets: "", reps: "" }],
        },
      ],
    });
  };

  return (
    <form
      onSubmit={handleSubmit(onSubmit)}
      className="max-w-3xl mx-auto p-6 bg-gray-800 shadow-lg rounded-lg mt-5"
    >
      <h2 className="text-2xl text-center font-bold text-white mb-4">
        Create Workout
      </h2>
      <input
        type="text"
        placeholder="Workout Name"
        {...register("name")}
        className="block w-full p-2 mb-2 border border-gray-300 text-gray-800 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
      />
      {fields.map((item, index) => (
        <div
          key={item.id}
          className="p-4 border border-gray-300 rounded-lg mb-6"
        >
          <div className="mb-4">
            <input
              placeholder="Routine Name"
              {...register(`singleWorkouts.${index}.name`)}
              className="block w-full p-2 mb-2 border border-gray-300 text-gray-800 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
            />
            <input
              placeholder="Day"
              type="number"
              {...register(`singleWorkouts.${index}.day`)}
              className="block w-full p-2 mb-2 border border-gray-300 text-gray-800 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
            />
          </div>
          <h3 className="text-lg font-bold mb-2">Exercises</h3>
          <ExerciseFields
            control={control}
            register={register}
            nestIndex={index}
            exercises={exercises}
            name={`singleWorkouts.${index}.exercisePerformInfos`}
          />
          <button
            type="button"
            onClick={() => remove(index)}
            className="mt-2 p-2 bg-red-500 text-white rounded hover:bg-red-600 focus:outline-none focus:ring-2 focus:ring-red-500"
          >
            Remove Workout
          </button>
        </div>
      ))}
      <button
        type="button"
        onClick={() =>
          append({
            name: "",
            day: "",
            exercisePerformInfos: [{ exerciseId: "", sets: "", reps: "" }],
          })
        }
        className="block w-full mb-4 p-2 bg-blue-500 text-white rounded hover:bg-blue-600 focus:outline-none focus:ring-2 focus:ring-blue-500"
      >
        Add Workout
      </button>
      <button
        type="submit"
        className="block w-full p-2 bg-green-500 text-white rounded hover:bg-green-600 focus:outline-none focus:ring-2 focus:ring-green-500"
      >
        Submit
      </button>
    </form>
  );
};

const ExerciseFields = ({ control, register, nestIndex, name, exercises }) => {
  const { fields, append, remove } = useFieldArray({
    control,
    name,
  });

  return (
    <div>
      {fields.map((item, index) => (
        <div key={item.id} className="mb-4 p-4 border border-gray-300 rounded">
          <select
            className="text-gray-800 block w-full p-2 mb-2 border border-gray-300 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"

            defaultValue={""}
            {...register(`${name}.${index}.exerciseId`)}
          >
            <option disabled value="">
              Select exercise
            </option>
            {exercises.map((exercise) => (
              <option key={exercise.id} value={exercise.id}>
                {exercise.name}
              </option>
            ))}
          </select>
          {/* <input
            placeholder="Exercise ID"
            type="number"
            {...register(`${name}.${index}.exerciseId`)}
            className="text-gray-800 block w-full p-2 mb-2 border border-gray-300 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
          /> */}
          <input
            placeholder="Sets"
            type="number"
            {...register(`${name}.${index}.sets`)}
            className="text-gray-800 block w-full p-2 mb-2 border border-gray-300 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
          />
          <input
            placeholder="Reps"
            type="number"
            {...register(`${name}.${index}.reps`)}
            className="text-gray-800 block w-full p-2 mb-2 border border-gray-300 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
          />
          <button
            type="button"
            onClick={() => remove(index)}
            className="mt-2 p-2 bg-red-500 text-white rounded hover:bg-red-600 focus:outline-none focus:ring-2 focus:ring-red-500"
          >
            Remove Exercise
          </button>
        </div>
      ))}
      <button
        type="button"
        onClick={() => append({ exerciseId: "", sets: "", reps: "" })}
        className="block w-full p-2 bg-blue-500 text-white rounded hover:bg-blue-600 focus:outline-none focus:ring-2 focus:ring-blue-500"
      >
        Add Exercise
      </button>
    </div>
  );
};

export default CreateWorkout2;

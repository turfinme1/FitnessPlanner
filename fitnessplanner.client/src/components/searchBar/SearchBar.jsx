import React, { useState } from "react";
import { useForm } from "react-hook-form";
import { getAllByMuscleGroup } from "../../services/exerciseService";

const SearchBar = ({setElements}) => {
  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
  } = useForm({
    mode: "onChange",
  });

  const submitHandler =async (values) => {
    const result = await getAllByMuscleGroup(values.muscleGroup);
    // console.log("result", result);
    setElements(prev=> [...result])
  };

  return (
    <form
      onSubmit={handleSubmit(submitHandler)}
      className="flex gap-2 flex-wrap w-full pb-10"
    >
      <div className="grow">
        <select
          className="w-full bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"

          defaultValue={""}
          {...register("muscleGroup", {
            required: "Muscle group is required",
          })}
        >
          <option disabled value={""}>
            Select a muscle group
          </option>
          <option key={1} value="Neck">
            Neck
          </option>
          <option key={2} value="Trapezius">
            Trapezius
          </option>
          <option key={3} value="Shoulder">
            Shoulder
          </option>
          <option key={4} value="Chest">
            Chest
          </option>
          <option key={5} value="Back">
            Back
          </option>
          <option key={6} value="Biceps">
            Biceps
          </option>
          <option key={7} value="Triceps">
            Triceps
          </option>
          <option key={8} value="Forearm">
            Forearm
          </option>
          <option key={9} value="Abs">
            Abs
          </option>
          <option key={10} value="Legs">
            Legs
          </option>
          <option key={11} value="Calves">
            Calves
          </option>
          <option key={12} value="Full Body">
            Full Body
          </option>
        </select>
      </div>

      <div className="grow">
        <button
          className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600"
          type="submit"
        >
          Search
        </button>
      </div>
    </form>
  );
};

export default SearchBar;

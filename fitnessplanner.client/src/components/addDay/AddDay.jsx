import { useForm } from "react-hook-form";

const AddDay = ({ setElements }) => {
  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
  } = useForm({
    mode: "onChange",
  });

  const submitHandler = (values) => {
    console.log(values);
    setElements((prev) => {
      if (prev.some((element) => element.day === values.day)) {
        return prev;
      }

      return [...prev, { day: values.day, id: values.day, name: values.name }];
    });
  };

  return (
    <form
      className="flex gap-2 pb-5 flex-wrap w-full"
      onSubmit={handleSubmit(submitHandler)}
    >
      {/* <label
        htmlFor="default"
        className="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
      >
        Select a day
      </label> */}
      <div className="grow">
        <select
          // className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500"
          className="w-full bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
          defaultValue={""}
          {...register("day", {
            required: "Day is required",
          })}
        >
          <option disabled value="">
            Select a day
          </option>
          <option key={1} value="1">
            Monday
          </option>
          <option key={2} value="2">
            Tuesday
          </option>
          <option key={3} value="3">
            Wednesday
          </option>
          <option key={4} value="4">
            Thursday
          </option>
          <option key={5} value="5">
            Friday
          </option>
          <option key={6} value="6">
            Saturday
          </option>
          <option key={7} value="7">
            Sunday
          </option>
        </select>
        {errors.day && (
          <span className="text-sm text-red-400">{errors.day?.message}</span>
        )}
      </div>

      <div className="grow">
        <input
          type="text"
          placeholder="Give a name to the Routine"
          className="w-full bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
          {...register("name", {
            required: "Name for the routine is required",
            minLength: { value: 6, message: "Minimum 6 characters" },
          })}
        />
        {errors.name && (
          <span className="text-sm text-red-400">{errors.name?.message}</span>
        )}
      </div>

      <div className="grow">
        <button
          className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600"
          type="submit"
        >
          Add
        </button>
      </div>
    </form>
  );
};

export default AddDay;

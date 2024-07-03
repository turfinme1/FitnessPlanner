import { useForm } from "react-hook-form";
import { useNavigate } from "react-router-dom";
import { updateProfile, getUserFormData } from "../../../services/userService";
import { useEffect } from "react";

const UpdateProfile = () => {
  const navigate = useNavigate();
  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
  } = useForm({
    mode: "onChange",
    defaultValues: async () => getUserFormData(),
  });

  // useEffect(() => {
  //   const fetchUserFormData = async () => {
  //     try {
  //       const data = await getUserFormData();
  //       console.log(data);
  //     } catch (error) {
  //       console.log("error", error);
  //     }
  //   };

  //   fetchUserFormData();
  // }, []);

  const handleRegistration = async (values) => {
    console.log(values);
    values.Id = JSON.parse(
      sessionStorage.getItem("authData")
    ).state.userData.nameidentifier;
    try {
      if (await updateProfile(values)) {
        navigate("/profile");
      }
    } catch (error) {
      console.log("error", error);
    }
  };

  return (
    <div className="flex w-full flex-col items-center py-5 sm:justify-center">
      <a
        href="#"
        className="flex items-center mb-6 text-2xl font-semibold text-gray-900 dark:text-white"
      >
        <img
          className="w-8 h-8 mr-2"
          src="./src/assets/bench-gym-svgrepo-com.svg"
          alt="logo"
        />
        Update Profile
      </a>
      <div className="w-full max-w-sm rounded-md  bg-white px-6 py-6 shadow-md dark:bg-gray-900 sm:rounded-lg">
        <form
          action=""
          onSubmit={handleSubmit(handleRegistration)}
          className="group"
        >
          <div className="mt-4">
            <label
              htmlFor="name"
              className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
            >
              Full Name
            </label>
            <div className="flex flex-col items-start">
              <input
                type="text"
                placeholder="Full Name"
                className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 placeholder-gray-300 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500 [&:not(:placeholder-shown):not(:focus):invalid~span]:block invalid:[&:not(:placeholder-shown):not(:focus)]:border-red-400 valid:[&:not(:placeholder-shown)]:border-green-500"
                {...register("name", {
                  required: "Field is required",
                  pattern: {
                    value:
                      /^[a-zA-Z]+(?:['-]?[a-zA-Z]+)*\s+[a-zA-Z]+(?:['-]?[a-zA-Z]+)*$/,
                    message: "Provide a valid name",
                  },
                  minLength: { value: 6, message: "Minimum 6 characters" },
                })}
              />

              {errors.name && (
                <span className="mt-1 text-sm text-red-400">
                  {errors.name?.message}
                </span>
              )}
            </div>
          </div>

          <div className="mt-4">
            <label
              htmlFor="age"
              className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
            >
              Age
            </label>
            <div className="flex flex-col items-start">
              <input
                type="number"
                className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 placeholder-gray-300 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500 [&:not(:placeholder-shown):not(:focus):invalid~span]:block invalid:[&:not(:placeholder-shown):not(:focus)]:border-red-400 valid:[&:not(:placeholder-shown)]:border-green-500"
                autoComplete="off"
                defaultValue={14}
                {...register("age", {
                  required: "Field is invalid",
                  min: { value: 14, message: "Minimum age is 14" },
                  max: { value: 99, message: "Maximum age is 99" },
                })}
              />

              {errors.age && (
                <span className="mt-1 text-sm text-red-400">
                  {errors.age?.message}
                </span>
              )}
            </div>
          </div>

          <div className="mt-4">
            <label
              htmlFor="height"
              className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
            >
              Height (cm)
            </label>
            <div className="flex flex-col items-start">
              <input
                type="number"
                className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 placeholder-gray-300 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500 [&:not(:placeholder-shown):not(:focus):invalid~span]:block invalid:[&:not(:placeholder-shown):not(:focus)]:border-red-400 valid:[&:not(:placeholder-shown)]:border-green-500"
                autoComplete="off"
                defaultValue={160}
                {...register("height", {
                  required: "Field is invalid",
                  min: { value: 140, message: "Minimum heigth is 140 cm" },
                  max: { value: 250, message: "Maximum height is 250 cm" },
                })}
              />

              {errors.height && (
                <span className="mt-1 text-sm text-red-400">
                  {errors.height?.message}
                </span>
              )}
            </div>
          </div>

          <div className="mt-4">
            <label
              htmlFor="weight"
              className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
            >
              Weight (kg)
            </label>
            <div className="flex flex-col items-start">
              <input
                type="number"
                className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 placeholder-gray-300 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500 [&:not(:placeholder-shown):not(:focus):invalid~span]:block invalid:[&:not(:placeholder-shown):not(:focus)]:border-red-400 valid:[&:not(:placeholder-shown)]:border-green-500"
                autoComplete="off"
                defaultValue={50}
                {...register("weight", {
                  required: "Field is invalid",
                  min: { value: 40, message: "Minimum weight is 40 kg" },
                  max: { value: 200, message: "Maximum weight is 200 kg" },
                })}
              />

              {errors.weight && (
                <span className="mt-1 text-sm text-red-400">
                  {errors.weight?.message}
                </span>
              )}
            </div>
          </div>

          <div className="mt-4">
            <label
              htmlFor="skillLevelId"
              className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
            >
              Skill Level
            </label>
            <select
              className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500"
              defaultValue={""}
              {...register("skillLevelId", {
                required: "Select your skill level",
              })}
            >
              <option disabled value={""}>
                Select your Skill Level
              </option>
              <option key={1} value={1}>
                {"Beginner"}
              </option>
              <option key={2} value={2}>
                {"Intermediate"}
              </option>
              <option key={3} value={3}>
                {"Advanced"}
              </option>
              <option key={4} value={4}>
                {"Professional"}
              </option>
            </select>

            {errors.skillLevelId && (
              <span className="mt-1 text-sm text-red-400">
                {errors.skillLevelId?.message}
              </span>
            )}
          </div>

          <div className="mt-4">
            <label
              htmlFor="goalId"
              className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
            >
              Goal
            </label>
            <select
              className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500"
              defaultValue={""}
              {...register("goalId", {
                required: "Field is invalid",
              })}
            >
              <option disabled value={""}>
                Select your Goal
              </option>
              <option key={1} value={1}>
                {"Lose weight"}
              </option>
              <option key={2} value={2}>
                {"Gain muscle"}
              </option>
              <option key={3} value={3}>
                {"Maintain weight"}
              </option>
            </select>

            {errors.goalId && (
              <span className="mt-1 text-sm text-red-400">
                {errors.goalId?.message}
              </span>
            )}
          </div>

          <div className="mt-4 flex items-center">
            <button
              type="submit"
              className="mt-2 w-full rounded-lg bg-purple-700 px-5 py-3 text-center text-sm font-medium text-white hover:bg-purple-600 focus:outline-none focus:ring-1 focus:ring-blue-300 disabled:cursor-not-allowed disabled:bg-gradient-to-br disabled:from-gray-100 disabled:to-gray-300 disabled:text-gray-400 group-invalid:pointer-events-none group-invalid:bg-gradient-to-br group-invalid:from-gray-100 group-invalid:to-gray-300 group-invalid:text-gray-400 group-invalid:opacity-70"
            >
              Update
            </button>
          </div>
        </form>

        <div className="my-6 space-y-2"></div>
      </div>
    </div>
  );
};

export default UpdateProfile;

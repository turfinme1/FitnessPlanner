import Section from "../section/Section";
import useUserAuth from "../../store/useUserAuth";
import { useForm } from "react-hook-form";

const Login = () => {
  const { login } = useUserAuth((state) => ({ login: state.login }));
  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
  } = useForm({
    mode: "onChange",
  });

  const handleLogin = async (values) => {
    console.log(values);
    try {
      await login(values);
    } catch (error) {
      console.log("error", error);
    }
  };

  return (
    <Section
      className="pt-[1rem] -mt-[5.25rem]"
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="login"
    >
      <div className="flex min-h-screen items-center justify-center px-4">
        <div className="flex w-full flex-col items-center py-10 sm:justify-center">
          <a
            href="#"
            className="flex items-center mb-6 text-2xl font-semibold text-white dark:text-white"
          >
            <img
              className="w-8 h-8 mr-2"
              src="./src/assets/bench-gym-svgrepo-com.svg"
              alt="logo"
            />
            Sign in
          </a>
          <div className="w-full max-w-sm rounded-md  bg-white px-6 py-6 shadow-md dark:bg-gray-900 sm:rounded-lg">
            <form
              action=""
              onSubmit={handleSubmit(handleLogin)}
              className="group"
            >
              <div className="mt-4">
                <label
                  htmlFor="email"
                  className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
                >
                  Email
                </label>
                <div className="flex flex-col items-start">
                  <input
                    placeholder="Email"
                    className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 placeholder-gray-300 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500 invalid:[&:not(:placeholder-shown):not(:focus)]:border-red-400 valid:[&:not(:placeholder-shown)]:border-green-500"
                    autoComplete="off"
                    {...register("email", {
                      required: "Field is required",
                      pattern: {
                        value: /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/,
                        message: "Invalid email",
                      },
                    })}
                  />

                  {errors.email && (
                    <span className="mt-1 text-sm text-red-400">
                      {errors.email.message}
                    </span>
                  )}
                </div>
              </div>

              <div className="mt-4">
                <label
                  htmlFor="password"
                  className="mb-2 block text-sm font-medium text-gray-900 dark:text-white"
                >
                  Password
                </label>
                <div className="flex flex-col items-start">
                  <input
                    type="password"
                    className="block w-full rounded-lg border border-gray-300 bg-gray-50 p-2.5 text-sm text-gray-900 placeholder-gray-300 focus:border-purple-500 focus:ring-purple-500 dark:border-gray-600 dark:bg-gray-700 dark:text-white dark:placeholder-gray-400 dark:focus:border-purple-500 dark:focus:ring-purple-500 [&:not(:placeholder-shown):not(:focus):invalid~span]:block invalid:[&:not(:placeholder-shown):not(:focus)]:border-red-400 valid:[&:not(:placeholder-shown)]:border-green-500"
                    autoComplete="off"
                    {...register("password", {
                      required: "Field is required",
                      minLength: { value: 6, message: "Minimum 6 characters" },
                    })}
                  />

                  {errors.password && (
                    <span className="mt-1 text-sm text-red-400">
                      {errors.password?.message}
                    </span>
                  )}
                </div>
              </div>
              <div className="mt-4 flex items-center">
                <button
                  type="submit"
                  className="mt-2 w-full rounded-lg bg-purple-700 px-5 py-3 text-center text-sm font-medium text-white hover:bg-purple-600 focus:outline-none focus:ring-1 focus:ring-blue-300 disabled:cursor-not-allowed disabled:bg-gradient-to-br disabled:from-gray-100 disabled:to-gray-300 disabled:text-gray-400 group-invalid:pointer-events-none group-invalid:bg-gradient-to-br group-invalid:from-gray-100 group-invalid:to-gray-300 group-invalid:text-gray-400 group-invalid:opacity-70"
                >
                  Sign in
                </button>
              </div>
            </form>

            <div className="my-6 space-y-2"></div>
          </div>
        </div>
      </div>
    </Section>
  );
};

export default Login;

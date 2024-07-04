export const getWorkoutById = async (id) => {
  const response = await fetch(`/workout-plan/${id}`);
  const result = await response.json();
  console.log(result);
  return result;
};

export const getWorkoutPlans = async () => {
  const response = await fetch("/workout-plan");
  const result = await response.json();
  console.log(result);
  return result;
};

export const createWorkoutPlan = async (workoutPlan) => {
  const response = await fetch("/workout-plan", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      Authorization:
        "Bearer " +
        JSON.parse(sessionStorage.getItem("authData")).state.accessToken,
    },
    body: JSON.stringify(workoutPlan),
  });
  const result = await response.json();
  console.log(result);
  return result;
};

export const getWorkoutSuggestion = async () => {
  const response = await fetch("/user/recommendation", {
    headers: {
      Authorization:
        "Bearer " +
        JSON.parse(sessionStorage.getItem("authData")).state.accessToken,
    },
  });
  const result = await response.json();
  console.log(result);
  return result;
};

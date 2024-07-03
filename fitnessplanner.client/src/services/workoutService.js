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
}

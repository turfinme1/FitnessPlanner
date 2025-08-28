export const getAllByMuscleGroup = async (muscleGroup) => {
  const response = await fetch(`api/exercise/${muscleGroup}`);
  const responseObject = await response.json();
  return responseObject.result;
};

export const getExercises = async () => {
  const response = await fetch("api/exercise/");
  const responseObject = await response.json();
  return responseObject.result;
};

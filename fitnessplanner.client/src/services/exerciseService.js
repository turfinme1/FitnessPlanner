export const getAllByMuscleGroup = async (muscleGroup) => {
    const response = await fetch(`api/exercise/${muscleGroup}`);
    const result = await response.json();
    
    return result;
}

export const getExercises = async () => {
    const response = await fetch("api/exercise/");
    const result = await response.json();
    console.log(result);
    return result;
  }
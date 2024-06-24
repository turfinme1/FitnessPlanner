export const getAllByMuscleGroup = async (muscleGroup) => {
    const response = await fetch(`exercise/${muscleGroup}`);
    const result = await response.json();
    
    return result;
}

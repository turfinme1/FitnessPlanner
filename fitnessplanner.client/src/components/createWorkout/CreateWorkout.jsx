import ExerciseList from "../list/ExerciseList";
import DayBoard from "../dayBoard/DayBoard";
import SearchBoard from "../searchBoard/SearchBoard";
import Section from "../section/Section";
import { useState } from "react";

const CreateWorkout = () => {
  const [workoutPlan, setWorkoutPlan] = useState(startWorkout);
  const [singleWorkouts, setSingleWorkouts] = useState(
    startWorkout.singleWorkouts
  );
  const [activeSingleWorkout, setActiveSingleWorkout] = useState([]);
  console.log(activeSingleWorkout);

  const handleSelectActiveDay = (day, e) => {
    

    setActiveSingleWorkout([singleWorkouts.find((workout) => workout.day === day)]);
  };

  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] h-full w-full p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="create"
    >
      <div className="flex items-start justify-between overflow-hidden gap-x-8 grow">
        <DayBoard
          elements={startWorkout.singleWorkouts}
          setElements={setSingleWorkouts}
          onClickHandler={handleSelectActiveDay}
        />
        <SearchBoard />
        <ExerciseList
          // by specific day
          elements={activeSingleWorkout}
          setElements={setActiveSingleWorkout}
        />
      </div>
    </Section>
  );
};

export default CreateWorkout;

const startWorkout = {
  name: "New workout from app",
  userId: "b40ab47f-7216-47af-a157-43003b1d261f",
  skillLevelId: 2,
  goalId: 3,
  singleWorkouts: [
    {
      name: "leg day",
      day: 1,
      exercisePerformInfos: [
        {
          exerciseId: 1,
          sets: 5,
          reps: 6,
        },
        {
          exerciseId: 55,
          sets: 5,
          reps: 10,
        },
        {
          exerciseId: 23,
          sets: 1,
          reps: 4,
        },
      ],
    },
    {
      name: "back day",
      day: 3,
      exercisePerformInfos: [
        {
          exerciseId: 11,
          sets: 5,
          reps: 6,
        },
        {
          exerciseId: 35,
          sets: 5,
          reps: 10,
        },
        {
          exerciseId: 22,
          sets: 1,
          reps: 4,
        },
      ],
    },
  ],
  bodyMassIndexMeasures: [1],
};

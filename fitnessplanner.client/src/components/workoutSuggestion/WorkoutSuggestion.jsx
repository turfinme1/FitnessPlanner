import Button from "../button/Button";
import Section from "../section/Section";
import WorkoutDetails from "../workoutDetails/workoutDetails";
import { getWorkoutSuggestion } from "../../services/workoutService";
import { useNavigate } from "react-router-dom";
import { useState } from "react";
const WorkoutSuggestion = () => {
  const navigate = useNavigate();
  const [workout, setWorkout] = useState({});

  const onGetSuggestion = () => {
    getWorkoutSuggestion().then((data) => {
      setWorkout(data);
      // navigate(`/workout-list/${data.id}`);
    });
  };

  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] h-full w-full p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="workout-list"
    >
      <section className="text-center flex flex-col min-h-screen">
        <div>
          <h1 className="text-center h1">Get a workout suggestion</h1>
        </div>
        <div className="text-center">
          <Button onClick={onGetSuggestion} className="">
            Get Suggestion
          </Button>
        </div>
        {workout?.id && <WorkoutDetails workoutData={workout} />}
      </section>
    </Section>
  );
};

export default WorkoutSuggestion;

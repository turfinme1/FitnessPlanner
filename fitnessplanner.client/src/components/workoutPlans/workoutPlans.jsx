import { useEffect, useState } from "react";
import Section from "../section/Section";
import WorkoutCard from "./workoutCard/WorkoutCard";
import { getWorkoutPlans } from "../../services/workoutService";

const WorkoutPlan = () => {
  const [workoutPlans, setWorkoutPlans] = useState([]);
  useEffect(() => {
    getWorkoutPlans().then((data) => {
      setWorkoutPlans(data);
    });
  }, []);

  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] h-full w-full p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="workout-list"
    >
      <div>
        <h1 className="text-center h1">Our Workout plans</h1>
      </div>
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4 items-center justify-items-center">
        {workoutPlans.map((workoutPlan, index) => (
          <WorkoutCard
            key={workoutPlan.id}
            img={index}
            id={workoutPlan.id}
            name={workoutPlan.name}
            goal={workoutPlan.goal}
            skillLevel={workoutPlan.skillLevel}
          />
        ))}
       
      </div>
    </Section>
  );
};

export default WorkoutPlan;

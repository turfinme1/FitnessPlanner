import ExerciseList from "../column/ExerciseList";
import SearchBoard from "../searchBoard/SearchBoard";
import Section from "../section/Section";

const CreateWorkout = () => {
  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] flex h-full w-full gap-3 overflow-scroll p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="hero"
    >
      <SearchBoard />
      <ExerciseList />
    </Section>
  );
};

export default CreateWorkout;

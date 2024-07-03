import React, { useState } from "react";
import ExerciseList from "../list/ExerciseList";
import AddDay from "../addDay/AddDay";
import List from "../list/List";

const DayBoard = ({ elements, setElements, onClickHandler }) => {
  const [days, setDays] = useState(elements);

  console.log(days);
  return (
    <div className="w-full h-full grow">
      <AddDay setElements={setDays} />
      <List
        elements={days}
        setElements={setDays}
        isSortable
        onClickHandler={onClickHandler}
      />
    </div>
  );
};

export default DayBoard;

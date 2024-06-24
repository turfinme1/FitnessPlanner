import React, { useState } from "react";
import ExerciseList from "../list/ExerciseList";
import AddDay from "../addDay/AddDay";
import List from "../list/List";

const DayBoard = () => {
  const [elements, setElements] = useState([]);

  console.log(elements);
  return (
    <div className="w-full h-full grow">
      <AddDay setElements={setElements} />
      <List elements={elements} setElements={setElements} isSortable />
    </div>
  );
};

export default DayBoard;

import React, { useState } from "react";
import List from "../../list/List";
import AddRoutine from "./addRoutine/AddRoutine";
import RoutineAccordionList from "./routineAccordionList/RoutineAccordionList";

const RoutineBoard = ({ elements, setElements, onClickHandler }) => {
  const [routines, setRoutines] = useState(elements);
  console.log(routines);
  return (
    <div className="w-full h-full grow">
      <RoutineAccordionList
        elements={routines}
        setElements={setRoutines}
        isSortable
        onClickHandler={onClickHandler}
      />
      <AddRoutine setElements={setRoutines} />
    </div>
  );
};

export default RoutineBoard;

import { useState } from "react";
import {
  DndContext,
  PointerSensor,
  TouchSensor,
  closestCorners,
  useSensor,
  useSensors,
} from "@dnd-kit/core";
import {
  SortableContext,
  arrayMove,
  sortableKeyboardCoordinates,
  verticalListSortingStrategy,
} from "@dnd-kit/sortable";
import Card from "../card/Card";

const ExerciseList = ({ elements, setElements }) => {
  const getTaskIndex = (id) => elements.findIndex((elements) => elements.id === id);

  const handleDragEnd = (event) => {
    const { active, over } = event;

    if (active.id === over.id) return;

    setElements((elements) => {
      const originIndex = getTaskIndex(active.id);
      const targetIndex = getTaskIndex(over.id);

      return arrayMove(elements, originIndex, targetIndex);
    });
  };

  const sensors = useSensors(
    useSensor(PointerSensor),
    useSensor(TouchSensor, {
      coordinateGetter: sortableKeyboardCoordinates,
    })
  );

  return (
    <div className="w-full h-full grow">
      <DndContext
        onDragEnd={handleDragEnd}
        collisionDetection={closestCorners}
        sensors={sensors}
      >
        {elements && <Column elements={elements} />}
      </DndContext>
    </div>
  );
};

const Column = ({ elements }) => {
  return (
    <div className="flex flex-col gap-1 grow">
      <SortableContext items={elements} strategy={verticalListSortingStrategy}>
        {elements.map((elements) => (
          <Card title={elements.name} id={elements.id} key={elements.id} isSortable/>
        ))}
      </SortableContext>
    </div>  
  );
};

const DEFAULT_CARDS = [
  { title: "Look into render bug in dashboard", id: "11" },
  { title: "SOX compliance checklist", id: "21" },
  { title: "[SPIKE] Migrate to Azure", id: "31" },
  { title: "Document Notifications service", id: "41" },
  { title: "Research DB options for new microservice", id: "51" },
  { title: "Postmortem for outage", id: "61" },
  { title: "Sync with product on Q3 roadmap", id: "71" },
  { title: "Refactor context providers to use Zustand", id: "81" },
  { title: "Add logging to daily CRON", id: "91" },
  { title: "Set up DD dashboards for Lambda listener", id: "101" },
];

export default ExerciseList;

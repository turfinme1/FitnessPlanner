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

const ExerciseList = () => {
  const [tasks, setTasks] = useState(DEFAULT_CARDS);

  const getTaskIndex = (id) => tasks.findIndex((task) => task.id === id);

  const handleDragEnd = (event) => {
    const { active, over } = event;

    if (active.id === over.id) return;

    setTasks((tasks) => {
      const originIndex = getTaskIndex(active.id);
      const targetIndex = getTaskIndex(over.id);

      return arrayMove(tasks, originIndex, targetIndex);
    });
  };

  const sensors = useSensors(
    useSensor(PointerSensor),
    useSensor(TouchSensor, {
      coordinateGetter: sortableKeyboardCoordinates,
    })
  );

  return (
    <div>
      <DndContext
        onDragEnd={handleDragEnd}
        collisionDetection={closestCorners}
        sensors={sensors}
      >
        <Column tasks={tasks} />
      </DndContext>
    </div>
  );
};

const Column = ({ tasks }) => {
  return (
    <div className="flex flex-col gap-1">
      <SortableContext items={tasks} strategy={verticalListSortingStrategy}>
        {tasks.map((task) => (
          <Card title={task.title} id={task.id} key={task.id} />
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

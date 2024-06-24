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
import ListCard from "../card/ListCard";

const List = ({ elements, setElements, isSortable }) => {
  const getTaskIndex = (id) =>
    elements.findIndex((element) => element.id === id);

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

  const NonSortableList = ({ children }) => {
    return (
      <div className="w-full h-full grow">
        {elements && (
          <div className="flex flex-col gap-1 grow">
            {elements.map((element) => (
              <ListCard id={element.id} key={element.day} {...element} />
            ))}
          </div>
        )}
      </div>
    );
  };

  const SortableList = () => {
    return (
      <div className="w-full h-full grow">
        <DndContext
          onDragEnd={handleDragEnd}
          collisionDetection={closestCorners}
          sensors={sensors}
        >
          {elements && (
            <div className="flex flex-col gap-1 grow">
              <SortableContext
                items={elements}
                strategy={verticalListSortingStrategy}
              >
                {elements.map((element) => (
                  <ListCard
                    {...element}
                    id={element.id}
                    key={element.day}
                    isSortable
                  />
                ))}
              </SortableContext>
            </div>
          )}
        </DndContext>
      </div>
    );
  };

  return isSortable ? <SortableList /> : <NonSortableList />;
};

export default List;

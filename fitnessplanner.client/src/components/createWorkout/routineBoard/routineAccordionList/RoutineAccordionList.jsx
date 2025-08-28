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
import ListCard from "../../../card/ListCard";
import { Accordion, AccordionItem } from "@szhsin/react-accordion";
import { accordionArrow } from "../../../../assets";
const RoutineAccordionList = ({
  elements,
  setElements,
  isSortable,
  onClickHandler,
}) => {
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
                    onClickHandler={onClickHandler}
                  />
                ))}
              </SortableContext>
            </div>
          )}
        </DndContext>
      </div>
    );
  };

  //   return isSortable ? <SortableList /> : <NonSortableList />;

  const Item = ({ header, ...rest }) => (
    <AccordionItem
      {...rest}
      header={({ state: { isEnter } }) => (
        <>
          {header}
          <img
            className={`ml-auto transition-transform duration-200 ease-out ${
              isEnter && "rotate-180"
            }`}
            src={accordionArrow}
            alt="arrow"
          />
        </>
      )}
      className="border-b bg-color-1"
      buttonProps={{
        className: ({ isEnter }) =>
          `flex w-full p-4 text-left hover:bg-slate-100 ${
            isEnter && "bg-slate-200"
          }`,
      }}
      contentProps={{
        className: "transition-height duration-200 ease-out",
      }}
      panelProps={{ className: "p-4" }}
    />
  );

  return (
    <Accordion>
      {elements.map((element) => (
        <Item header={element.name}>{element.day}</Item>
      ))}
    </Accordion>
  );
};

export default RoutineAccordionList;

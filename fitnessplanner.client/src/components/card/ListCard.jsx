import { useSortable } from "@dnd-kit/sortable";
import { CSS } from "@dnd-kit/utilities";

const ListCard = ({ day, name, id, isSortable, onClickHandler }) => {
  const { attributes, listeners, setNodeRef, transform, transition } =
    useSortable({ id });

  const style = { transition, transform: CSS.Transform.toString(transform) };

  const SortableCard = () => {
    return (
      <div
        ref={setNodeRef}
        {...attributes}
        {...listeners}
        style={style}
        onClick={(e) => onClickHandler(day, e)}
        className="cursor-grab rounded border border-neutral-700 bg-neutral-800 p-3 active:cursor-grabbing touch-none"
      >
        <p className="text-sm text-neutral-100">{`Day ${day} : ${name}`}</p>
      </div>
    );
  };

  const NonSortableCard = () => {
    return (
      <div
        ref={setNodeRef}
        style={style}
        onClick={(e) => onClickHandler(day, e)}
        className="rounded border border-neutral-700 bg-neutral-800 p-3 touch-none cursor-pointer"
      >
        <p className="text-sm text-neutral-100">{`Day ${day} : ${name}`}</p>
      </div>
    );
  };

  return isSortable ? <SortableCard /> : <NonSortableCard />;
};

export default ListCard;

import { Link } from "react-router-dom";

const WorkoutCard = ({ id, name, goal, skillLevel, img }) => {
  return (
    <div className="max-w-sm bg-white border border-gray-200 rounded-lg shadow dark:bg-gray-800 dark:border-gray-700">
      <div className="flex items-center justify-between p-5 border-b border-gray-200 dark:border-gray-700">
      <Link to={`/workout-list/${id}`}>
        <img
          className="rounded-t-lg"
          src={`https://artshopimgs.blob.core.windows.net/images/plan${img+1}.jpg`}
          alt="Image"
        />
      </Link>
      </div>
      <div className="p-5">
        <Link to={`/workout-list/${id}`}>
          <h5 className="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white text-center">
            {name}
          </h5>
        </Link>
        <p className="mb-3 font-normal text-gray-700 dark:text-gray-400 text-center">
          {goal || "Here are the biggest enterprise technology"}{" "}
          {skillLevel}
        </p>
        <div className="flex items-center justify-center">
          <Link
            to={`/workout-list/${id}`}
            className="inline-flex items-center px-3 py-2 text-sm font-medium text-center text-white bg-blue-700 rounded-lg hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"
          >
            View details
            <svg
              className="rtl:rotate-180 w-3.5 h-3.5 ms-2"
              aria-hidden="true"
              xmlns="http://www.w3.org/2000/svg"
              fill="none"
              viewBox="0 0 14 10"
            >
              <path
                stroke="currentColor"
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth="2"
                d="M1 5h12m0 0L9 1m4 4L9 9"
              />
            </svg>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default WorkoutCard;

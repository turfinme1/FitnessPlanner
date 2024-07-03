const ExerciseCard = ({ exerciseName, reps, sets }) => {
  return (
    <div className="w-full p-4 text-center border  rounded-lg shadow sm:p-8 bg-gray-800 border-gray-700 grid grid-cols-1 md:grid-cols-3 gap-4">
      <div className="flex flex-col justify-center">
        <h5 className="mb-2 text-3xl font-bold text-white">
          {exerciseName}
        </h5>
      </div>
      <div className="flex justify-center w-full h-full conent-center">
        <img
          src={`https://artshopimgs.blob.core.windows.net/images/${exerciseName.replace(/\s+/g, '') + '.gif'}`}
          alt={exerciseName}
          className="lg:w-1/2 h-auto rounded-lg shadow-md"
        />
      </div>
      <div className="flex flex-col items-center justify-center space-y-4">
        <a
          href="#"
          className="w-full sm:w-auto bg-gray-800 hover:bg-gray-700 focus:ring-4 focus:outline-none focus:ring-gray-300 text-white rounded-lg inline-flex items-center justify-center px-4 py-2.5 dark:bg-gray-700 dark:hover:bg-gray-600 dark:focus:ring-gray-700"
        >
          <div className="">
            <div className=" font-sans font-semibold">
              {`Sets: ${sets} Reps: ${reps}`}
            </div>
          </div>
        </a>
      </div>
    </div>
  );
};

export default ExerciseCard;

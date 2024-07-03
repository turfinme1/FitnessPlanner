const ProfileMenu = () => {
  return (
    <>
      <div className="grow text-center text-color-2">
        <h2 className="h2 font-bold uppercase">User Menu</h2>
      </div>
      <div className="grow">
        <button className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600">
          Add exercise - Admin
        </button>
      </div>
      
      <div className="grow">
        <button className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600">
          Update exercise - Admin
        </button>
      </div>

      <div className="grow">
        <button className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600">
          Display users - Admin
        </button>
      </div>

      <div className="grow">
        <button className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600">
          Create workout for user - Trainer
        </button>
      </div>

      <div className="grow">
        <button className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600">
          Update Workout
        </button>
      </div>

      <div className="grow">
        <button className="w-full h-11 rounded-lg bg-purple-700 px-5 text-center text-sm font-bold text-white hover:bg-purple-600">
          Update Profile Info
        </button>
      </div>
    </>
  );
};

export default ProfileMenu;

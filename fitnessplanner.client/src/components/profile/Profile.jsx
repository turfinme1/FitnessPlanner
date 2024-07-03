import ExerciseList from "../list/ExerciseList";
import DayBoard from "../dayBoard/DayBoard";
import SearchBoard from "../searchBoard/SearchBoard";
import Section from "../section/Section";
import Register from "../register/Register";
import ProfileMenu from "./profileMenu/ProfileMenu";
import UpdateProfile from "./updateProfile/UpdateProfile";

const Profile = () => {
  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] h-full w-full p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="profile"
    >
      <div className="flex items-start overflow-hidden gap-x-8 flex-wrap md:flex-nowrap">
        <div className="flex gap-2 pb-5 flex-wrap w-full h-full flex-col grow md:w-1/2">
          <ProfileMenu />
        </div>
        <div className="flex min-h-screen items-center justify-center px-4 w-full h-full grow">
          <UpdateProfile />
        </div>
      </div>
    </Section>
  );
};

export default Profile;

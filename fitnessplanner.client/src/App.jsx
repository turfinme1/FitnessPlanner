import { useEffect, useState } from "react";
import ButtonGradient from "./assets/svg/ButtonGradient";
import Button from "./components/button/Button";
import Header from "./components/header/Header";
import Hero from "./components/hero/Hero";
import Login from "./components/login/Login";
import { Route, Routes } from "react-router-dom";
import Register from "./components/register/Register";
import SearchBoard from "./components/searchBoard/SearchBoard";
import CreateWorkout from "./components/createWorkout/CreateWorkout";
import Profile from "./components/profile/Profile";
import WorkoutPlan from "./components/workoutPlans/workoutPlans";
import WorkoutDetails from "./components/workoutDetails/workoutDetails";
import CreateWorkout2 from "./components/createWorkout/CreateWorkout2";

function App() {
  return (
    <div className="pt-[4.75rem] lg:pt-[5.25rem] overflow-hidden">
      <Header />
      <ButtonGradient />
      <Routes>
        <Route path="/" element={<Hero />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/create-workout" element={<CreateWorkout2 />} />
        <Route path="/workout-list" element={<WorkoutPlan />} />
        <Route path="workout-list/:workoutId" element={<WorkoutDetails />} />
        <Route path="/profile" element={<Profile />} />
      </Routes>
    </div>
  );
}

export default App;

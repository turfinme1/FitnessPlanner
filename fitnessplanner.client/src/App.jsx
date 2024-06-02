import { useEffect, useState } from "react";
import ButtonGradient from "./assets/svg/ButtonGradient";
import Button from "./components/button/Button";
import Header from "./components/header/Header";
import Hero from "./components/hero/Hero";
import Login from "./components/login/Login";
import { Route, Routes } from "react-router-dom";
import Register from "./components/register/Register";

function App() {
  return (
    <div className="pt-[4.75rem] lg:pt-[5.25rem] overflow-hidden">
      <Header />
      <ButtonGradient />
      <Routes>
        <Route path="/" element={<Hero />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
      </Routes>
      
    </div>
  );
}

export default App;

// const [forecasts, setForecasts] = useState();

//   useEffect(() => {
//     populateWeatherData();
//   }, []);
// const contents =
//     forecasts === undefined ? (
//       <p>
//         <em>
//           Loading... Please refresh once the ASP.NET backend has started. See{" "}
//           <a href="https://aka.ms/jspsintegrationreact">
//             https://aka.ms/jspsintegrationreact
//           </a>{" "}
//           for more details.
//         </em>
//       </p>
//     ) : (
//       <table className="table table-striped" aria-labelledby="tabelLabel">
//         <thead>
//           <tr>
//             <th>Date</th>
//             <th>Temp. (C)</th>
//             <th>Temp. (F)</th>
//             <th>Summary</th>
//           </tr>
//         </thead>
//         <tbody>
//           {forecasts.map((forecast) => (
//             <tr key={forecast.date}>
//               <td>{forecast.date}</td>
//               <td>{forecast.temperatureC}</td>
//               <td>{forecast.temperatureF}</td>
//               <td>{forecast.summary}</td>
//             </tr>
//           ))}
//         </tbody>
//       </table>
//     );

//   return (
//     <>
//       <h1 className="text-3xl font-bold underline">Hello world!</h1>
//       {contents}
//     </>
//   );

//   async function populateWeatherData() {
//     const response = await fetch("weatherforecast");
//     const data = await response.json();
//     setForecasts(data);
//   }

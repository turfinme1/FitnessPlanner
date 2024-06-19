import React, { useState } from "react";
import ExerciseList from "../column/ExerciseList";

const SearchBar = () => {
  const [cards, setCards] = useState(DEFAULT_CARDS);
  const [selected, setSelected] = useState("");
  return (
    // <div className="mb-3 xl:w-96">
    //   <div className="mb-4 flex w-full flex-wrap items-stretch">
    //     <input
    //       type="search"
    //       className="relative m-0 block flex-auto rounded border border-solid border-neutral-300 bg-transparent bg-clip-padding px-3 py-[0.25rem] text-base font-normal leading-[1.6] text-neutral-700 outline-none transition duration-200 ease-in-out focus:z-[3] focus:border-primary focus:shadow-[inset_0_0_0_1px_rgb(59,113,202)] focus:outline-none dark:border-neutral-600 dark:text-neutral-200 dark:placeholder:text-neutral-200 dark:focus:border-primary"
    //       placeholder="Search"
    //       aria-label="Search"
    //       aria-describedby="button-addon2"
    //     />

    //     <button
    //       className="z-[2] inline-block rounded-e border-2 border-primary px-6 pb-[6px] pt-2 text-xs font-medium uppercase leading-normal text-primary transition duration-150 ease-in-out hover:border-primary-accent-300 hover:bg-primary-50/50 hover:text-primary-accent-300 focus:border-primary-600 focus:bg-primary-50/50 focus:text-primary-600 focus:outline-none focus:ring-0 active:border-primary-700 active:text-primary-700 dark:text-primary-500 dark:hover:bg-blue-950 dark:focus:bg-blue-950"
    //       data-twe-ripple-init
    //       data-twe-ripple-color="white"
    //       type="button"
    //       id="button-addon3"
    //     >
    //       Search
    //     </button>

    //     {/* <!--Search icon--> */}
    //     {/* <ExerciseList title="Todo" cards={cards} setCards={setCards}/> */}
    //   </div>
    // </div>

    <form>
      <label
        for="default"
        class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
      >
        Find exercise by group
      </label>
      <select
        id="default"
        class="bg-gray-50 border border-gray-300 text-gray-900 mb-6 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
      >
        <option selected>Choose a country</option>
        <option value="US">United States</option>
        <option value="CA">Canada</option>
        <option value="FR">France</option>
        <option value="DE">Germany</option>
      </select>

      {/* <ExerciseList /> */}
    </form>
  );
};

const DEFAULT_CARDS = [
  { title: "Look into render bug in dashboard", id: "1" },
  { title: "SOX compliance checklist", id: "2" },
  { title: "[SPIKE] Migrate to Azure", id: "3" },
  { title: "Document Notifications service", id: "4" },
  { title: "Research DB options for new microservice", id: "5" },
  { title: "Postmortem for outage", id: "6" },
  { title: "Sync with product on Q3 roadmap", id: "7" },
  { title: "Refactor context providers to use Zustand", id: "8" },
  { title: "Add logging to daily CRON", id: "9" },
  { title: "Set up DD dashboards for Lambda listener", id: "10" },
];

export default SearchBar;

import React, { useState } from "react";
import SearchBar from "../searchBar/SearchBar";
import Section from "../section/Section";
import ExerciseList from "../list/ExerciseList";
import List from "../list/List";

const SearchBoard = () => {
  const [cards, setCards] = useState(DEFAULT_CARDS);

  return (
    <div className="w-full h-full grow">
      <>
        <SearchBar setElements={setCards}/>
        <ExerciseList elements={cards} setElements={setCards} />
      </>
    </div>
  );
};

const DEFAULT_CARDS = [
  { name: "Look into render bug in dashboard", id: "11" },
  { name: "SOX compliance checklist", id: "21" },
  { name: "[SPIKE] Migrate to Azure", id: "31" },
  { name: "Document Notifications service", id: "41" },
  { name: "Research DB options for new microservice", id: "51" },
  { name: "Postmortem for outage", id: "61" },
  { name: "Sync with product on Q3 roadmap", id: "71" },
  { name: "Refactor context providers to use Zustand", id: "81" },
  { name: "Add logging to daily CRON", id: "91" },
  { name: "Set up DD dashboards for Lambda listener", id: "101" },
];

export default SearchBoard;

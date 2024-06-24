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
  { title: "Look into render bug in dashboard", id: "11" },
  { title: "SOX compliance checklist", id: "21" },
  { title: "[SPIKE] Migrate to Azure", id: "31" },
  { title: "Document Notifications service", id: "41" },
  { title: "Research DB options for new microservice", id: "51" },
  { title: "Postmortem for outage", id: "61" },
  { title: "Sync with product on Q3 roadmap", id: "71" },
  { title: "Refactor context providers to use Zustand", id: "81" },
  { title: "Add logging to daily CRON", id: "91" },
  { title: "Set up DD dashboards for Lambda listener", id: "101" },
];

export default SearchBoard;

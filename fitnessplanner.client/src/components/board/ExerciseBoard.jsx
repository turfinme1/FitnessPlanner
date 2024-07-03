import React, { useState } from "react";
import SearchBar from "../searchBar/SearchBar";
import Section from "../section/Section";

const ExerciseBoard = () => {
  const [cards, setCards] = useState(DEFAULT_CARDS);

  return (
    <Section
      className="pt-[6rem] -mt-[5.25rem] flex h-full w-full gap-3 overflow-scroll p-12 "
      crosses
      crossesOffset="lg:translate-y-[5.25rem]"
      customPaddings
      id="hero"
    >
      <>
         <SearchBar /> 
        {/* <ExerciseList title="Tasks" cards={cards} setCards={setCards} /> */}
      </>
    </Section>
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

export default ExerciseBoard;

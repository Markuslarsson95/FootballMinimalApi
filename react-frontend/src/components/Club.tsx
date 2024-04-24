import { useState, useEffect } from "react";
import axios from "axios";

function ClubComponent() {
  const [clubs, setClubs] = useState<any[]>([]);

  const fetchClubs = async () => {
    const { data } = await axios.get("https://localhost:7154/clubs");
    const clubs = data;
    setClubs(clubs);
  };

  useEffect(() => {
    fetchClubs();
  }, []);

  return (
    <>
      <h1>Clubs</h1>
      <div className="list-group">
        {clubs.map((club) => (
          <a
            href="#"
            className="list-group-item list-group-item-action"
            key={club.id}
          >
            {club.name}
          </a>
        ))}
      </div>
    </>
  );
}

export default ClubComponent;

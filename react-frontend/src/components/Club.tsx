import { useState, useEffect } from "react";
import axios from "axios";

function ClubComponent() {
  const [clubs, setClubs] = useState<any[]>([]);

  const fetchClubs = async () => {
    const { data } = await axios.get("https://localhost:7154/clubs");
    const clubs = data;
    setClubs(clubs);
    console.log(clubs);
  };

  useEffect(() => {
    fetchClubs();
  }, []);

  return (
    <>
      <h1>Clubs</h1>
      <ul className="list-group">
        {clubs.map((club) => (
          <li key={club.id}>{club.name}</li>
        ))}
      </ul>
    </>
  );
}

export default ClubComponent;

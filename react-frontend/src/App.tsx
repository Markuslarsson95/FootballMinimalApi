import { useState } from "react";
import Alert from "./components/Alert";
import Button from "./components/Button";
import ListGroup from "./components/ListGroup";
import ClubComponent from "./components/Club";

function App() {
  useState(false);
  const [alertVisible, setAlertVisibility] = useState(false);
  const [showClubComponent, setShowClubComponent] = useState(false);
  return (
    <div>
      {alertVisible && (
        <Alert
          onClose={() => {
            setAlertVisibility(false);
            setShowClubComponent(false);
          }}
        >
          <span>My alert</span>
        </Alert>
      )}
      {showClubComponent && <ClubComponent />}
      <Button
        color="primary"
        onClick={() => {
          setAlertVisibility(true);
          setShowClubComponent(true);
        }}
      >
        My button
      </Button>
    </div>
  );
}

export default App;

import "./App.css";

import { Header, Icon } from "semantic-ui-react";

function App() {
  return (
    <div>
      <Header as="h2">
        <Icon name="users" />
        <Header.Content>Reactivities</Header.Content>
      </Header>
    </div>
  );
}

export default App;

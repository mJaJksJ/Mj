import React from 'react';
import {Tabs} from "@mui/material";
import LinkTab from "../../utils/linkTab/LinkTab";

function Header() {
  const [value, setValue] = React.useState(0);

  const handleChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
  };

  return (
      <Tabs
          value={value}
          onChange={handleChange}
          textColor="secondary"
          indicatorColor="secondary"
          aria-label="secondary tabs example"
          centered
      >
        <LinkTab label="vk" href="/vk"/>
        <LinkTab label="habr" href="/habr"/>
      </Tabs>
  );
}

export default Header;

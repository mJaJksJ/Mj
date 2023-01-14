import React from "react";
import {Tab} from "@mui/material";
import {useHistory} from "react-router-dom";

interface LinkTabProps {
  label?: string;
  href: string;
}

export default function LinkTab(props: LinkTabProps) {
  const history = useHistory();

  return (
      <Tab
          onClick={(event: React.MouseEvent<HTMLAnchorElement, MouseEvent>) => {
            history.push(props.href, null);
            event.preventDefault();
          }}
          {...props}
      />
  );
}
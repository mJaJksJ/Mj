import React from "react";
import {publicRoutes} from "./router";
import {Route, Switch} from "react-router-dom";
import Header from "../header/Header";

function AppRouter() {
  return (
      <>
        <Header/>
        <Switch>
          {publicRoutes.map(route =>
              <Route
                  component={route.component}
                  path={route.path}
                  exact={route.exact}
                  key={route.path}
              />
          )}
        </Switch>
      </>
  );
};

export default AppRouter;
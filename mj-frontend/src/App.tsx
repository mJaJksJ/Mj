import React from 'react';
import './App.css';
import {createTheme, ThemeProvider} from "@mui/material";
import {BrowserRouter} from "react-router-dom";
import AppRouter from "./components/appRouter/AppRouter";

function App() {
  const theme = createTheme({
    palette: {
      primary: {
        main: '#3d5afe',
      },
      secondary: {
        main: '#673ab7',
      },
    },
  });

  return (
      <ThemeProvider theme={theme}>
        <BrowserRouter>
          <AppRouter/>
        </BrowserRouter>
      </ThemeProvider>
  );
}

export default App;

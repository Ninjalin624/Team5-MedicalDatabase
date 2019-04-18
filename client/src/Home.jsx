import React from "react"
import ReactDOM from "react-dom"

import { withStyles, createMuiTheme, MuiThemeProvider } from "@material-ui/core/styles"

import Hero from "./components/Hero"
import Navbar from "./containers/Navbar"

const theme = createMuiTheme({
  typography: {
    useNextVariants: true
  }
});

const Home = (props) => (
  <MuiThemeProvider theme={theme}>
    <Navbar />
    <Hero />
  </MuiThemeProvider>
);

ReactDOM.render(
  <Home />,
  document.getElementById("root")
);

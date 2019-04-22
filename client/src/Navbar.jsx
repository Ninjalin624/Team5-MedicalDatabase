import React, { Suspense } from "react"
import ReactDOM from "react-dom"

import { createMuiTheme, MuiThemeProvider } from "@material-ui/core/styles"

import ContainerNavbar from "./containers/Navbar";

const theme = createMuiTheme({
  typography: {
    useNextVariants: true
  }
});

const Navbar = (props) => (
  <MuiThemeProvider theme={theme}>
    <Suspense fallback={<div>Loading header...</div>}>
      <ContainerNavbar />
    </Suspense>
  </MuiThemeProvider>
);

ReactDOM.render(
  <Navbar />,
  document.getElementById("navbar")
);

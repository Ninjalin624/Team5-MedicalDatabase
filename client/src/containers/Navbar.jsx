import React from "react"

import AppBar from "@material-ui/core/AppBar"
import Button from "@material-ui/core/Button"
import IconButton from "@material-ui/core/IconButton"
import Link from "@material-ui/core/Link"
import List from "@material-ui/core/List"
import ListItem from "@material-ui/core/ListItem"
import ListItemIcon from "@material-ui/core/ListItemIcon"
import ListItemText from "@material-ui/core/ListItemText"
import SwipeableDrawer from "@material-ui/core/SwipeableDrawer"
import Toolbar from "@material-ui/core/Toolbar"
import { withStyles } from "@material-ui/core"
import DashboardIcon from "@material-ui/icons/Dashboard"
import LocationCityIcon from "@material-ui/icons/LocationCity"
import InfoIcon from "@material-ui/icons/Info"
import MenuIcon from "@material-ui/icons/Menu"

const styles = theme => ({
  drawerList: {
    width: 250
  },
  title: {
    fontFamily: "Arial",
    fontSize: 28
  },
  toolbar: {
    justifyContent: "space-between"
  },
  right: {
    flex: 1,
    display: "flex",
    justifyContent: "flex-end"
  }
});

class Navbar extends React.Component {
  constructor(props) {
    super(props)
    this.state = {
      showDrawer: false
    }

    this.openDrawer = this.openDrawer.bind(this)
    this.closeDrawer = this.closeDrawer.bind(this)
  }

  render() {
    const { classes } = this.props;

    return <div>
      <AppBar position="fixed">
        <Toolbar className={classes.toolbar}>
          <Link className={classes.title} variant="h1" color="inherit" underline="none" href="./">MUICLINIC</Link>
          <div className={classes.right}>
            <Button color="inherit">Login</Button>
            <IconButton color="inherit" aria-label="Menu" onClick={this.openDrawer}>
              <MenuIcon />
            </IconButton>
          </div>
        </Toolbar>
      </AppBar>
      <SwipeableDrawer anchor="right" open={this.state.showDrawer}
        onOpen={this.openDrawer}
        onClose={this.closeDrawer}>
        <List className={classes.drawerList}>
          <ListItem button component="a" href="/About">
            <ListItemIcon><InfoIcon /></ListItemIcon>
            <ListItemText primary="About" />
          </ListItem>
          <ListItem button component="a" href="/Offices">
            <ListItemIcon><LocationCityIcon /></ListItemIcon>
            <ListItemText primary="Offices" />
          </ListItem>
          <ListItem button component="a" href="/Portal">
            <ListItemIcon><DashboardIcon /></ListItemIcon>
            <ListItemText primary="Portal" />
          </ListItem>
        </List>
      </SwipeableDrawer>
    </div>
  }

  openDrawer() { this.setState({ showDrawer: true }); }
  closeDrawer() { this.setState({ showDrawer: false }); }
}

export default withStyles(styles)(Navbar)
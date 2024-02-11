import { useTheme } from "@mui/material/styles";
import Box from "@mui/material/Box";
import CssBaseline from "@mui/material/CssBaseline";
import Divider from "@mui/material/Divider";
import { useState } from "react";
import NavIcon from "./NavIcon";
import DrawerSideBar, { DrawerHeader } from "./DrawerSideBar";
import LeftGenericMenuBar from "./LeftGenericMenuBar";
import LeftMenuBarAccount from "./LeftMenuBarAccount";
import LayoutAppBar from "./LayoutAppBar";
import { Typography } from "@mui/material";
import HomeButton from "../../Features/HomePage/HomeButton";
import LogoutButton from "../../Features/UserProfile/LogoutButton";
import AddTweetButton from "../../Features/Tweets/AddTweetButton";

export default function PostLoginNavLayout({ children }: any) {
  const theme = useTheme();
  const [open, setOpen] = useState(false);

  const handleDrawerOpen = () => {
    setOpen(true);
  };

  const handleDrawerClose = () => {
    setOpen(false);
  };

  return (
    <Box sx={{ display: "flex" }}>
      <CssBaseline />
      <LayoutAppBar open={open}>
        <NavIcon open={open} handleDrawerOpen={handleDrawerOpen} />
        <Typography
          variant="h6"
          noWrap
          component="div"
          sx={{ marginRight: "1.5%" }}
        >
          Explore The World
        </Typography>
        <HomeButton />
        <AddTweetButton />
        <LogoutButton />
      </LayoutAppBar>
      <DrawerSideBar
        handleDrawerClose={handleDrawerClose}
        theme={theme}
        open={open}
      >
        <Divider />
        <LeftGenericMenuBar open={open} />
        <Divider />
        <LeftMenuBarAccount open={open} />
      </DrawerSideBar>
      <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
        <DrawerHeader />
        {children}
      </Box>
    </Box>
  );
}

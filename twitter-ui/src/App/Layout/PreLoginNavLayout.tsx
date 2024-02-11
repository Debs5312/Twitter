import Box from "@mui/material/Box";
import CssBaseline from "@mui/material/CssBaseline";
import { DrawerHeader } from "./DrawerSideBar";
import LayoutAppBar from "./LayoutAppBar";
import { Avatar, Typography } from "@mui/material";
import LoginButton from "../../Features/UserProfile/LoginButton";
import SignupButton from "../../Features/UserProfile/SignupButton";

export default function PreLoginNavLayout({ children }: any) {
  return (
    <Box sx={{ display: "flex" }}>
      <CssBaseline />
      <LayoutAppBar open={false}>
        <Avatar
          sx={{ marginRight: 3 }}
          aria-label="recipe"
          alt="Twitter"
          src="./Images/TwitterAvatar.jpg"
        />
        <Typography variant="h6" noWrap component="div">
          Explore the World
        </Typography>
        <SignupButton />
        <LoginButton />
      </LayoutAppBar>
      <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
        <DrawerHeader />
        {children}
      </Box>
    </Box>
  );
}

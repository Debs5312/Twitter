import { styled, Toolbar } from "@mui/material";
import { drawerWidth } from "./DrawerSideBar";
import MuiAppBar, { AppBarProps as MuiAppBarProps } from "@mui/material/AppBar";

interface Props {
  open: boolean;
  children: any;
}

interface AppBarProps extends MuiAppBarProps {
  open?: boolean;
}

const AppBar = styled(MuiAppBar, {
  shouldForwardProp: (prop) => prop !== "open",
})<AppBarProps>(({ theme, open }) => ({
  zIndex: theme.zIndex.drawer + 1,
  transition: theme.transitions.create(["width", "margin"], {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.leavingScreen,
  }),
  ...(open && {
    marginLeft: drawerWidth,
    width: `calc(100% - ${drawerWidth}px)`,
    transition: theme.transitions.create(["width", "margin"], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
  }),
}));

export default function LayoutAppBar({ open, children }: Props) {
  return (
    <AppBar position="fixed" open={open}>
      <Toolbar>{children}</Toolbar>
    </AppBar>
  );
}

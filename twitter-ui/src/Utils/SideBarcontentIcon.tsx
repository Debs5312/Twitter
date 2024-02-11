import FeedIcon from "@mui/icons-material/Feed";
import GroupsSharpIcon from "@mui/icons-material/GroupsSharp";
import GroupAddSharpIcon from "@mui/icons-material/GroupAddSharp";
import NewspaperSharpIcon from "@mui/icons-material/NewspaperSharp";
import AccountCircleSharpIcon from "@mui/icons-material/AccountCircleSharp";
import SettingsIcon from "@mui/icons-material/Settings";

export const items = [
  {
    id: 1,
    name: "All Tweets",
    icon: <FeedIcon />,
  },
  {
    id: 2,
    name: "My Tweets",
    icon: <NewspaperSharpIcon />,
  },
  {
    id: 3,
    name: "Following",
    icon: <GroupAddSharpIcon />,
  },
  {
    id: 4,
    name: "Follower",
    icon: <GroupsSharpIcon />,
  },
];

export const account = [
  {
    id: 1,
    name: "Account",
    icon: <AccountCircleSharpIcon />,
  },
  {
    id: 2,
    name: "Settings",
    icon: <SettingsIcon />,
  },
];

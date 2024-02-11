import { Button } from "@mui/material";
import LogoutIcon from "@mui/icons-material/Logout";
import { Link } from "react-router-dom";
import { store } from "../../Stores/CentralStore";

export default function LogoutButton() {
  const { userStore } = store;
  const { logout } = userStore;
  return (
    <Link to="/">
      <Button
        endIcon={<LogoutIcon />}
        size="large"
        sx={{ color: "#fff" }}
        onClick={() => logout()}
      >
        Logout
      </Button>
    </Link>
  );
}

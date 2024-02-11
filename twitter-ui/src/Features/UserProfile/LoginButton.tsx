import { Button } from "@mui/material";
import LoginIcon from "@mui/icons-material/Login";
import { Link } from "react-router-dom";

export default function LoginButton() {
  return (
    <Link to="loginform">
      <Button endIcon={<LoginIcon />} size="large" sx={{ color: "#fff" }}>
        Login
      </Button>
    </Link>
  );
}

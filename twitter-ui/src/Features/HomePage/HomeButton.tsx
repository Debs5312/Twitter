import HomeIcon from "@mui/icons-material/Home";
import { Button } from "@mui/material";

export default function HomeButton() {
  return (
    <Button
      startIcon={<HomeIcon />}
      size="large"
      sx={{ marginLeft: "55%", marginRight: "1.5%", color: "#ffff" }}
      href="/"
    >
      Home
    </Button>
  );
}

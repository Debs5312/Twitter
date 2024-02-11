import { Button } from "@mui/material";
import PersonPinIcon from "@mui/icons-material/PersonPin";

export default function SignupButton() {
  return (
    <Button
      endIcon={<PersonPinIcon />}
      size="large"
      sx={{ marginLeft: "65%", marginRight: "1%", color: "#fff" }}
    >
      SignUP
    </Button>
  );
}

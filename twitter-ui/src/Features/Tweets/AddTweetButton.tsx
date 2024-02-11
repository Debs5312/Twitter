import { Button } from "@mui/material";
import MapsUgcIcon from "@mui/icons-material/MapsUgc";
import { Link } from "react-router-dom";

export default function AddTweetButton() {
  return (
    <Link to="/login/addTweet">
      <Button
        endIcon={<MapsUgcIcon />}
        size="large"
        sx={{ color: "#fff", marginRight: "1%" }}
      >
        New
      </Button>
    </Link>
  );
}

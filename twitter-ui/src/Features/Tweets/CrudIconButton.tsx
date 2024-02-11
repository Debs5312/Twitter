import { IconButton, Menu, MenuItem } from "@mui/material";
import MoreVertIcon from "@mui/icons-material/MoreVert";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import Tweet from "../../Models/tweet";
import { useStore } from "../../Stores/CentralStore";

interface Props {
  tweet: Tweet;
}

export default function CrudIconButton({ tweet }: Props) {
  const { tweetStore } = useStore();
  const { deleteTweet } = tweetStore;
  const [anchorEl, setAnchorEl] = useState(null);
  const navigate = useNavigate();

  const handleClick = (event: any) => {
    setAnchorEl(event.currentTarget);
  };

  const open = Boolean(anchorEl);

  const handleClose = () => {
    setAnchorEl(null);
  };

  const handleDelete = (id: string) => {
    setAnchorEl(null);
    deleteTweet(id).then(() => navigate("/login"));
  };

  return (
    <>
      <IconButton
        aria-label="more"
        onClick={handleClick}
        aria-haspopup="true"
        aria-controls="long-menu"
      >
        <MoreVertIcon />
      </IconButton>
      <Menu anchorEl={anchorEl} keepMounted onClose={handleClose} open={open}>
        <MenuItem onClick={handleClose}>Share via Whatsapp</MenuItem>
        <MenuItem onClick={() => navigate(`/login/editTweet/${tweet.id}`)}>
          Edit Content
        </MenuItem>
        <MenuItem onClick={() => handleDelete(tweet.id)}>Delete</MenuItem>
      </Menu>
    </>
  );
}

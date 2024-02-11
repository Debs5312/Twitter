import {
  Avatar,
  Backdrop,
  Box,
  Button,
  Container,
  Paper,
  SelectChangeEvent,
  TextField,
  Typography,
} from "@mui/material";
import LoadingButton from "@mui/lab/LoadingButton";
import ArticleIcon from "@mui/icons-material/Article";
import ArrowLeftIcon from "@mui/icons-material/ArrowLeft";
import RestartAltRoundedIcon from "@mui/icons-material/RestartAltRounded";
import { Link, useNavigate } from "react-router-dom";

import { ChangeEvent, useState } from "react";
import PostLoginNavLayout from "../../App/Layout/PostLoginNavLayout";
import Copyright from "../../App/Layout/Copyright";
import DialogSelect from "./DialogSelect";
import UploadFile from "./UploadFile";
import { useStore } from "../../Stores/CentralStore";
import Tweet from "../../Models/tweet";
import { v4 as uuid } from "uuid";
import { observer } from "mobx-react-lite";

function TweetForm() {
  const { tweetStore } = useStore();
  const { createTweet, loading } = tweetStore;
  const navigate = useNavigate();
  const [title, setTitle] = useState<string>("");
  const [tweetcontext, setTweetcontext] = useState<string>("");
  const [category, setCategory] = useState<string>("");

  const handleSetCategory = (event: SelectChangeEvent<string>) => {
    setCategory(event.target.value);
  };

  const handleSetTitle = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    setTitle(event.target.value);
  };

  const handleSetTweetcontext = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    setTweetcontext(event.target.value);
  };

  const handleSubmit = (event: any) => {
    event.preventDefault();

    const newTweet: Tweet = {
      id: uuid(),
      title: title,
      tweetcontext: tweetcontext,
      category: category,
      date: new Date().toISOString(),
      imagePath: "india.jpg",
    };
    createTweet(newTweet).then(() => navigate("/login"));
  };

  const handleReset = () => {
    setTitle("");
    setTweetcontext("");
    setCategory("");
  };

  return (
    <PostLoginNavLayout>
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={true}
      >
        <Container
          component={Paper}
          maxWidth="xs"
          sx={{ mt: 2, p: 1 }}
          elevation={15}
        >
          <Box
            sx={{
              marginTop: 3,
              display: "flex",
              flexDirection: "column",
              alignItems: "center",
            }}
          >
            <Avatar sx={{ m: 1, bgcolor: "secondary.main" }}>
              <ArticleIcon />
            </Avatar>
            <Typography component="h1" variant="h5">
              Whats New Today
            </Typography>
            <Box
              component="form"
              onSubmit={handleSubmit}
              noValidate
              sx={{ mt: 1 }}
            >
              <TextField
                margin="normal"
                required
                fullWidth
                label="Title"
                autoFocus
                value={title}
                onChange={handleSetTitle}
              />
              <TextField
                margin="normal"
                required
                fullWidth
                label="Description"
                value={tweetcontext}
                onChange={handleSetTweetcontext}
              />
              <DialogSelect
                category={category}
                handleSetCategory={handleSetCategory}
              />
              <UploadFile />
              <LoadingButton
                disabled={false}
                loading={loading}
                type="submit"
                fullWidth
                variant="contained"
                sx={{ mt: 3, mb: 2 }}
              >
                Add a New Tweet
              </LoadingButton>
              <Link to="/login">
                <Button
                  startIcon={<ArrowLeftIcon />}
                  variant="contained"
                  color="error"
                  sx={{
                    mt: 2,
                    mb: 1,
                    mr: "45%",
                  }}
                >
                  Go Back
                </Button>
              </Link>
              <Button
                endIcon={<RestartAltRoundedIcon />}
                variant="contained"
                color="success"
                sx={{
                  mt: 2,
                  mb: 1,
                }}
                onClick={handleReset}
              >
                Reset
              </Button>
            </Box>
          </Box>
          <Copyright sx={{ mt: 2, mb: 3 }} />
        </Container>
      </Backdrop>
    </PostLoginNavLayout>
  );
}

export default observer(TweetForm);

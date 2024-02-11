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
import ArticleIcon from "@mui/icons-material/Article";
import ArrowLeftIcon from "@mui/icons-material/ArrowLeft";
import { Link, useNavigate, useParams } from "react-router-dom";
import { ChangeEvent, useEffect, useState } from "react";
import PostLoginNavLayout from "../../App/Layout/PostLoginNavLayout";
import Copyright from "../../App/Layout/Copyright";
import DialogSelect from "./DialogSelect";
import UploadFile from "./UploadFile";
import { useStore } from "../../Stores/CentralStore";
import { observer } from "mobx-react-lite";
import Tweet from "../../Models/tweet";
import LoadingButton from "@mui/lab/LoadingButton";

function TweetEditForm() {
  const { id } = useParams();
  const navigate = useNavigate();
  const { tweetStore } = useStore();
  const { setSingleTweet, loading, updateTweet } = tweetStore;
  const [tweet, setTweet] = useState<Tweet>({
    id: "",
    title: "",
    tweetcontext: "",
    category: "",
    imagePath: "",
    date: "",
  });

  useEffect(() => {
    if (id) setSingleTweet(id).then((tweet) => setTweet(tweet));
  }, [id, setSingleTweet]);

  const handleSetCategory = (event: SelectChangeEvent<string>) => {
    const { value } = event.target;
    setTweet({ ...tweet, category: value });
  };

  const handleSetTitle = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { value } = event.target;
    setTweet({ ...tweet, title: value });
  };

  const handleSetTweetcontext = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { value } = event.target;
    setTweet({ ...tweet, tweetcontext: value });
  };

  const handleSubmit = (event: any) => {
    event.preventDefault();
    updateTweet(tweet).then(() => navigate("/login"));
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
              Let's Change your opinion
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
                value={tweet.title}
                onChange={handleSetTitle}
              />
              <TextField
                margin="normal"
                required
                fullWidth
                label="Description"
                value={tweet.tweetcontext}
                onChange={handleSetTweetcontext}
              />
              <DialogSelect
                category={tweet.category}
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
                Update your Tweet
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
            </Box>
          </Box>
          <Copyright sx={{ mt: 2, mb: 3 }} />
        </Container>
      </Backdrop>
    </PostLoginNavLayout>
  );
}

export default observer(TweetEditForm);

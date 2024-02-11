import { Grid } from "@mui/material";
import { observer } from "mobx-react-lite";
import { useEffect } from "react";
import LoadingComponent from "../../App/Layout/LoadingComponent";
import { useStore } from "../../Stores/CentralStore";
import TweetCard from "./TweetCard";

function TweetCardList() {
  const { tweetStore } = useStore();
  const { allTweets, fetchTweetList, loading } = tweetStore;

  useEffect(() => {
    fetchTweetList();
  }, [tweetStore, fetchTweetList]);

  if (loading) return <LoadingComponent />;

  return (
    <Grid container rowSpacing={2} columnSpacing={1} sx={{ marginBottom: 3 }}>
      {allTweets.map((tweet) => (
        <TweetCard tweet={tweet} key={tweet.id} />
      ))}
    </Grid>
  );
}

export default observer(TweetCardList);

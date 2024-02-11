import { makeAutoObservable, runInAction } from "mobx";
import agent from "../App/API/Agent";
import Tweet from "../Models/tweet";

export default class TweetStore {
  tweetRegistry = new Map<string, Tweet>();
  loading: boolean = false;
  tweet: Tweet = {
    id: "",
    title: "",
    tweetcontext: "",
    category: "",
    imagePath: "",
    date: "",
  };

  constructor() {
    makeAutoObservable(this);
  }

  get allTweets() {
    return Array.from(this.tweetRegistry.values());
  }

  private getTweet = (key: string) => {
    return this.tweetRegistry.get(key);
  };

  private selectTweet = (tweet: Tweet) => {
    this.tweet = tweet;
  };

  setLoading = (value: boolean) => {
    this.loading = value;
  };

  setSingleTweet = async (id: string) => {
    const tweet = this.getTweet(id);
    if (tweet) {
      this.selectTweet(tweet);
      return this.tweet;
    } else {
      this.setLoading(true);
      try {
        const tweet = await agent.tweetRequests.Tweet(id);
        this.selectTweet(tweet);
        this.setLoading(false);
        return tweet;
      } catch (error) {
        console.log(error);
        this.setLoading(false);
      }
    }
    return this.tweet;
  };

  setTweetinRegistry = (tweetList: Tweet[]) => {
    tweetList.forEach((tweet) => {
      this.tweetRegistry.set(tweet.id, tweet);
    });
  };

  fetchTweetList = async () => {
    if (this.tweetRegistry.size) return this.allTweets;
    else {
      this.setLoading(true);
      try {
        const tweetList = await agent.tweetRequests.TweetList();
        this.setTweetinRegistry(tweetList);
        this.setLoading(false);
      } catch (error) {
        console.log(error);
        this.setLoading(false);
      }
    }
  };

  createTweet = async (tweet: Tweet) => {
    this.setLoading(true);
    try {
      await agent.tweetRequests.CreateTweet(tweet);
      runInAction(() => {
        this.tweetRegistry.set(tweet.id, tweet);
      });
      this.setLoading(false);
    } catch (error) {
      console.log(error);
      this.setLoading(true);
    }
  };

  updateTweet = async (tweet: Tweet) => {
    this.setLoading(true);
    try {
      await agent.tweetRequests.UpdateTweet(tweet);
      runInAction(() => {
        this.tweetRegistry.set(tweet.id, tweet);
        this.tweet = tweet;
      });
      this.setLoading(false);
    } catch (error) {
      console.log(error);
      this.setLoading(true);
    }
  };

  deleteTweet = async (id: string) => {
    this.setLoading(true);
    try {
      await agent.tweetRequests.DeleteTweet(id);
      runInAction(() => {
        this.tweetRegistry.delete(id);
      });
      this.setLoading(false);
    } catch (error) {
      console.log(error);
      this.setLoading(true);
    }
  };
}

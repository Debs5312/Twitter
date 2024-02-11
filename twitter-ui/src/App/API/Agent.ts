import axios, { AxiosResponse } from "axios";
import Tweet from "../../Models/tweet";

const sleep = (delay: number) => {
  return new Promise((resolve) => {
    setTimeout(resolve, delay);
  });
};

axios.defaults.baseURL = "";

axios.interceptors.response.use(async (response) => {
  try {
    await sleep(1000);
    return response;
  } catch (error) {
    console.log(error);
    return await Promise.reject(error);
  }
});

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const requests = {
  get: <T>(url: string) => axios.get<T>(url).then(responseBody),
  post: <T>(url: string, body: {}) =>
    axios.post<T>(url, body).then(responseBody),
  put: <T>(url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
  delete: <T>(url: string) => axios.delete<T>(url).then(responseBody),
};

const tweetRequests = {
  TweetList: () =>
    requests.get<Tweet[]>("http://localhost:4000/tweet/TweetApi"),
  Tweet: (id: string) =>
    requests.get<Tweet>(`http://localhost:4000/tweet/TweetApi/${id}`),
  CreateTweet: (tweet: Tweet) =>
    requests.post<void>("http://localhost:4000/tweet/TweetApi/Add", tweet),
  UpdateTweet: (tweet: Tweet) =>
    requests.put<void>(
      `http://localhost:4000/tweet/TweetApi/Edit/${tweet.id}`,
      tweet
    ),
  DeleteTweet: (id: string) =>
    requests.delete<void>(`http://localhost:4000/tweet/TweetApi/Delete/${id}`),
};

const agent = {
  tweetRequests,
};

export default agent;

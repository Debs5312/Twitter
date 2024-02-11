import { createContext, useContext } from "react";
import TweetStore from "./TweetStore";
import UserStore from "./UserStore";

interface Store {
  tweetStore: TweetStore;
  userStore: UserStore;
}

export const store: Store = {
  tweetStore: new TweetStore(),
  userStore: new UserStore(),
};

export const StoreContext = createContext(store);

export function useStore() {
  return useContext(StoreContext);
}

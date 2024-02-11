import { createBrowserRouter, RouteObject } from "react-router-dom";
import App from "../App/Layout/App";
import TweetEditForm from "../Features/Forms/TweetEditForm";
import TweetForm from "../Features/Forms/TweetForm";
import PostLoginPage from "../Features/Login/PostLoginPage";
import PreLoginPage from "../Features/Login/PreLoginPage";
import LoginForm from "../Features/UserProfile/LoginForm";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <App />,
    children: [
      { path: "", element: <PreLoginPage /> },
      { path: "loginform", element: <LoginForm /> },
      { path: "login", element: <PostLoginPage /> },
      { path: "login/addTweet", element: <TweetForm /> },
      { path: "login/editTweet/:id", element: <TweetEditForm /> },
    ],
  },
];

export const router = createBrowserRouter(routes);

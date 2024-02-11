import { makeAutoObservable, runInAction } from "mobx";
import User, { LoginFormInputs } from "../Models/user";
import UserAgent from "../App/API/UserAgent";

export default class UserStore {
  loading: boolean = false;
  user: User | null = null;
  errorMessage: boolean = false;
  token: string | null | undefined = null;
  appLoaded: boolean = false;

  constructor() {
    makeAutoObservable(this);
  }

  get isLoggedIn() {
    return !!this.user;
  }

  setLoading = (value: boolean) => {
    this.loading = value;
  };

  setError = (value: boolean) => {
    this.errorMessage = value;
  };

  setToken = (token: string | null) => {
    if (token) localStorage.setItem("jwt", token);
    this.token = token;
  };

  setApploaded = () => {
    this.appLoaded = true;
  };

  login = async (creds: LoginFormInputs) => {
    this.setLoading(true);
    this.setError(false);
    try {
      const user = await UserAgent.userRequests.Login(creds);
      this.setToken(user.token);
      runInAction(() => (this.user = user));
      this.setLoading(false);
    } catch (error) {
      console.log(error);
      this.setError(true);
      this.setLoading(false);
    }
  };

  logout = () => {
    this.setToken(null);
    localStorage.removeItem("jwt");
    this.user = null;
  };
}

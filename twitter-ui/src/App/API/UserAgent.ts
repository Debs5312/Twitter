import axios, { AxiosResponse } from "axios";
import User, { LoginFormInputs, RegisterFormInputs } from "../../Models/user";

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

const userRequests = {
  User: () => requests.get<User>("http://localhost:4500/api/user"),
  Login: (loginInfo: LoginFormInputs) =>
    requests.post<User>(`http://localhost:4500/api/user/login`, loginInfo),
  Register: (registerInfo: RegisterFormInputs) =>
    requests.post<User>(
      "http://localhost:4500/api/user/register",
      registerInfo
    ),
};

const UserAgent = {
  userRequests,
};

export default UserAgent;

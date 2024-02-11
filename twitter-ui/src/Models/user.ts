export default interface User {
  username: string;
  displayName: string;
  token: string;
  image?: string;
  bio?: string;
}

export interface RegisterFormInputs {
  email: string;
  passowrd: string;
  displayName?: string;
  username: string;
  bio?: string;
}

export interface LoginFormInputs {
  email: string;
  password: string;
}

import {
  Avatar,
  Backdrop,
  Box,
  Button,
  Container,
  FormControl,
  IconButton,
  InputAdornment,
  InputLabel,
  OutlinedInput,
  Paper,
  TextField,
  Typography,
} from "@mui/material";
import { ChangeEvent, useState } from "react";
import PreLoginNavLayout from "../../App/Layout/PreLoginNavLayout";
import { LoadingButton } from "@mui/lab";
import { Link, useNavigate } from "react-router-dom";
import LoginIcon from "@mui/icons-material/Login";
import ArrowLeftIcon from "@mui/icons-material/ArrowLeft";
import RestartAltRoundedIcon from "@mui/icons-material/RestartAltRounded";
import Copyright from "../../App/Layout/Copyright";
import { Visibility, VisibilityOff } from "@mui/icons-material";
import { observer } from "mobx-react-lite";
import { useStore } from "../../Stores/CentralStore";
import { LoginFormInputs } from "../../Models/user";

function LoginForm() {
  const { userStore } = useStore();
  const { login, isLoggedIn, loading, errorMessage } = userStore;
  const navigate = useNavigate();
  const [email, setEmail] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [showPassword, setShowPassword] = useState<boolean>(false);

  const handleClickShowPassword = () => setShowPassword((show) => !show);

  const handleMouseDownPassword = (
    event: React.MouseEvent<HTMLButtonElement>
  ) => {
    event.preventDefault();
  };

  const handleSetEmail = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    setEmail(event.target.value);
  };

  const handleSetPassword = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    setPassword(event.target.value);
  };

  const handleSubmit = (event: any) => {
    event.preventDefault();
    const loggedInDetails: LoginFormInputs = {
      email: email,
      password: password,
    };
    login(loggedInDetails).then(() => navigate("/login"));
  };

  const handleReset = () => {
    setEmail("");
    setPassword("");
  };

  return (
    <PreLoginNavLayout>
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
              <LoginIcon />
            </Avatar>
            <Typography component="h1" variant="h5">
              Sign In
            </Typography>
            <Box component="form" onSubmit={handleSubmit} sx={{ mt: 1 }}>
              <TextField
                error={email.length > 2 && email.length < 7}
                margin="normal"
                required
                fullWidth
                label="Email"
                autoFocus
                type="email"
                value={email}
                onChange={handleSetEmail}
                helperText={
                  email.length > 2 && email.length < 5 ? "Invalid Email id" : ""
                }
              />
              <FormControl
                variant="outlined"
                fullWidth
                required
                margin="normal"
              >
                <InputLabel htmlFor="outlined-adornment-password">
                  Password
                </InputLabel>
                <OutlinedInput
                  id="outlined-adornment-password"
                  type={showPassword ? "text" : "password"}
                  endAdornment={
                    <InputAdornment position="end">
                      <IconButton
                        aria-label="toggle password visibility"
                        onClick={handleClickShowPassword}
                        onMouseDown={handleMouseDownPassword}
                        edge="end"
                      >
                        {showPassword ? <VisibilityOff /> : <Visibility />}
                      </IconButton>
                    </InputAdornment>
                  }
                  label="Password"
                  autoFocus
                  value={password}
                  onChange={handleSetPassword}
                />
              </FormControl>
              <LoadingButton
                disabled={false}
                loading={loading}
                type="submit"
                fullWidth
                variant="contained"
                sx={{ mt: 3, mb: 2 }}
              >
                Login
              </LoadingButton>
              <Link to="/">
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
          {errorMessage ? (
            <Typography variant="h6" align="center" color="red">
              *Wrong Credentials
            </Typography>
          ) : (
            ""
          )}
        </Container>
      </Backdrop>
    </PreLoginNavLayout>
  );
}

export default observer(LoginForm);

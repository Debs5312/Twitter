import IconButton from "@mui/material/IconButton";
import MenuIcon from "@mui/icons-material/Menu";

export default function NavIcon({ open, handleDrawerOpen }) {
  return (
    <IconButton
      color="inherit"
      aria-label="open drawer"
      onClick={handleDrawerOpen}
      edge="start"
      sx={{
        marginRight: 5,
        ...(open && { display: "none" }),
      }}
    >
      <MenuIcon />
    </IconButton>
  );
}

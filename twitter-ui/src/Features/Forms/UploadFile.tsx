import { Stack, IconButton } from "@mui/material";
import FileUploadOutlinedIcon from "@mui/icons-material/FileUploadOutlined";

export default function UploadFile() {
  return (
    <Stack direction="column" alignItems="center" spacing={2}>
      <IconButton color="primary" aria-label="upload picture" component="label">
        <FileUploadOutlinedIcon />
        Upload Image *
        <input hidden accept="image/*" type="file" />
      </IconButton>
    </Stack>
  );
}

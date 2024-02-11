import * as React from "react";
import Box from "@mui/material/Box";
import Button from "@mui/material/Button";
import Dialog from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogTitle from "@mui/material/DialogTitle";
import InputLabel from "@mui/material/InputLabel";
import MenuItem from "@mui/material/MenuItem";
import FormControl from "@mui/material/FormControl";
import Select, { SelectChangeEvent } from "@mui/material/Select";
import { FormHelperText } from "@mui/material";

interface Props {
  category: string;
  handleSetCategory: (event: SelectChangeEvent<string>) => void;
}

export default function DialogSelect({ category, handleSetCategory }: Props) {
  const [open, setOpen] = React.useState(false);

  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleClose = (
    event: React.SyntheticEvent<unknown>,
    reason?: string
  ) => {
    if (reason !== "backdropClick") {
      setOpen(false);
    }
  };

  return (
    <>
      <Button onClick={handleClickOpen}>
        Select the category of your content *
      </Button>
      <Dialog disableEscapeKeyDown open={open} onClose={handleClose}>
        <DialogTitle>Choose Category</DialogTitle>
        <DialogContent>
          <Box component="form" sx={{ display: "flex", flexWrap: "wrap" }}>
            <FormControl variant="filled" sx={{ m: 1, minWidth: 120 }} required>
              <InputLabel id="demo-simple-select-filled-label">
                Category
              </InputLabel>
              <Select
                labelId="demo-simple-select-filled-label"
                id="demo-simple-select-filled-label"
                value={category}
                label="Category *"
                onChange={handleSetCategory}
              >
                <MenuItem value="economy">Economy</MenuItem>
                <MenuItem value="politics">Geopolitics</MenuItem>
                <MenuItem value="defense">Military & Defense</MenuItem>
                <MenuItem value="sports">Sports & Games</MenuItem>
              </Select>
              <FormHelperText>Required</FormHelperText>
            </FormControl>
          </Box>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>Cancel</Button>
          <Button onClick={handleClose}>Ok</Button>
        </DialogActions>
      </Dialog>
    </>
  );
}

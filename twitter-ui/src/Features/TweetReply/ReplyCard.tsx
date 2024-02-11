import { Avatar, ListItem, ListItemIcon, ListItemText } from "@mui/material";
import { red } from "@mui/material/colors";
import { Box } from "@mui/system";

interface Props {
  data: string[] | undefined;
  index: number;
  style: any;
}

export default function ReplyCard({ data, index, style }: Props) {
  return (
    <div style={style}>
      <Box key={data![index]}>
        <ListItem>
          <ListItemIcon>
            <Avatar
              sx={{ bgcolor: red[500] }}
              aria-label="recipe"
              alt="Boys"
              src="./Images/Boy.jpg"
            />
          </ListItemIcon>
          <ListItemText primary={data![index]} />
        </ListItem>
      </Box>
    </div>
  );
}

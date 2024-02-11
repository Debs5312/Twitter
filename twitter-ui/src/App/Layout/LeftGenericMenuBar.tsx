import { ListItemButton, ListItemIcon, ListItemText } from "@mui/material";
import { List, ListItem } from "semantic-ui-react";
import { items } from "../../Utils/SideBarcontentIcon";

interface Props {
  open: boolean;
}

export default function LeftGenericMenuBar({ open }: Props) {
  return (
    <List>
      {items.map((item) => (
        <ListItem key={item.id} disablepadding="true" sx={{ display: "block" }}>
          <ListItemButton
            sx={{
              minHeight: 48,
              justifyContent: open ? "initial" : "center",
              px: 2.5,
            }}
          >
            <ListItemIcon
              sx={{
                minWidth: 0,
                mr: open ? 3 : "auto",
                justifyContent: "center",
              }}
            >
              {item.icon}
            </ListItemIcon>
            <ListItemText primary={item.name} sx={{ opacity: open ? 1 : 0 }} />
          </ListItemButton>
        </ListItem>
      ))}
    </List>
  );
}

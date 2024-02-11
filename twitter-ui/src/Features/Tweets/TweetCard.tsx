import {
  Avatar,
  AvatarGroup,
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Grid,
  IconButton,
  IconButtonProps,
  styled,
  TextField,
} from "@mui/material";
import { useState } from "react";
import ExpandMoreIcon from "@mui/icons-material/ExpandMore";
import { red } from "@mui/material/colors";
import ReplyCard from "../TweetReply/ReplyCard";
import { FixedSizeList } from "react-window";
import CrudIconButton from "./CrudIconButton";
import Tweet from "../../Models/tweet";
import date from "../../Utils/DateTimeConverter";

interface ExpandMoreProps extends IconButtonProps {
  expand: boolean;
}

const replies = [
  "Aacadaksadljklf.dDNSB.KJDwkdnwqaDSdsgavdsfcefdsx",
  "Amit",
  "Barun",
  "Asa",
  "Aacadaksadljklf.dDNSB.KJDwkdnwqaDSdsgavdsfcefdsx",
  "Amit",
  "Barun",
  "Asa",
  "Aacadaksadljklf.dDNSB.KJDwkdnwqaDSdsgavdsfcefdsx",
  "Amit",
  "Barun",
  "Asa",
];

interface Props {
  tweet: Tweet;
}

const styles = {
  media: {
    height: 0,
    paddingTop: "56.25%", // 16:9,
    marginTop: "30",
  },
};

const ExpandMore = styled((props: ExpandMoreProps) => {
  const { expand, ...other } = props;
  return <IconButton {...other} />;
})(({ theme, expand }) => ({
  transform: !expand ? "rotate(270deg)" : "rotate(90deg)",
  marginLeft: "auto",
  transition: theme.transitions.create("transform", {
    duration: theme.transitions.duration.shortest,
  }),
}));

export default function TweetCard({ tweet }: Props) {
  const [expanded, setExpanded] = useState(false);
  const [reply, setReply] = useState("");

  const handleExpandClick = () => {
    setExpanded(!expanded);
  };

  const handlePostReply = (value: string) => {
    replies.push(value);
    console.log(replies);
  };

  return !expanded ? (
    <Grid item xs={12}>
      <Card sx={{ p: 1 }}>
        <CardHeader
          avatar={
            <Avatar
              sx={{ bgcolor: red[500] }}
              aria-label="recipe"
              alt="Boys"
              src="./Images/Boy.jpg"
            />
          }
          action={<CrudIconButton tweet={tweet} />}
          titleTypographyProps={{ variant: "h4" }}
          title={tweet.title}
          subheader={date(tweet.date)}
        />
        <CardMedia
          component="img"
          image={`./Images/${tweet.imagePath}`}
          alt={tweet.title}
          sx={{ height: "80vh", width: "80%", objectFit: "contain" }}
        />
        <CardContent sx={{ fontSize: 15 }}>{tweet.tweetcontext}</CardContent>
        <CardActions disableSpacing>
          <ExpandMore
            expand={expanded}
            onClick={handleExpandClick}
            aria-expanded={expanded}
            aria-label="show more"
          >
            <ExpandMoreIcon />
          </ExpandMore>
        </CardActions>
      </Card>
    </Grid>
  ) : (
    <>
      <Grid item xs={8}>
        <Card sx={{ p: 1 }}>
          <CardHeader
            avatar={
              <Avatar
                sx={{ bgcolor: red[500] }}
                aria-label="recipe"
                alt="Boys"
                src="./Images/Boy.jpg"
              />
            }
            action={<CrudIconButton tweet={tweet} />}
            titleTypographyProps={{ variant: "h4" }}
            title={tweet.title}
            subheader={date(tweet.date)}
          />
          <CardMedia
            component="img"
            image={`./Images/${tweet.imagePath}`}
            alt={tweet.title}
            sx={{ height: "80vh", width: "90%", objectFit: "contain" }}
          />
          <CardContent sx={{ fontSize: 15 }}>{tweet.tweetcontext}</CardContent>
          <CardActions disableSpacing>
            <ExpandMore
              expand={expanded}
              onClick={handleExpandClick}
              aria-expanded={expanded}
              aria-label="show more"
            >
              <ExpandMoreIcon />
            </ExpandMore>
          </CardActions>
        </Card>
      </Grid>
      <Grid item xs={4}>
        <Card>
          <CardHeader
            avatar={
              <AvatarGroup max={3}>
                <Avatar alt="Boys" src="./Images/Boy.jpg" />
                <Avatar alt="Boys" src="./Images/Boy.jpg" />
                <Avatar alt="Boys" src="./Images/Boy.jpg" />
                <Avatar alt="Boys" src="./Images/Boy.jpg" />
              </AvatarGroup>
            }
            titleTypographyProps={{ variant: "h5", paddingLeft: 10 }}
            subheaderTypographyProps={{ paddingLeft: 10 }}
            title="Reply ..."
            subheader="September 14, 2016"
          />
          <CardContent>
            <CardActions>
              <TextField
                id="outlined-basic"
                label="Reply"
                variant="outlined"
                value={reply}
                onChange={(event: React.ChangeEvent<HTMLInputElement>) => {
                  setReply(event.target.value);
                }}
              />
              <Button
                size="small"
                type="submit"
                variant="outlined"
                sx={{ alignContent: "center", marginLeft: 5 }}
                onClick={() => handlePostReply(reply)}
              >
                POST
              </Button>
            </CardActions>
          </CardContent>
          <CardContent>
            <FixedSizeList
              itemData={replies}
              itemCount={replies.length}
              itemSize={90}
              width="100%"
              height={5 * 100}
            >
              {ReplyCard}
            </FixedSizeList>
          </CardContent>
        </Card>
      </Grid>
    </>
  );
}

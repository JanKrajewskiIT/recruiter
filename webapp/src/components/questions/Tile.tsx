import { type Props } from "@/models/props";
import { Divider, IconButton, Paper, Typography, styled } from "@mui/material";
import { AiFillLike } from "react-icons/ai";
import { IoBug, IoExpandSharp } from "react-icons/io5";

interface ITileProps {
  title: string;
  description?: string;
}

const Tile = ({ className, title, description }: Props<ITileProps>) => (
  <Paper className={className} elevation={3}>
    <div className="tile-content">
      <Typography className="tile-title" gutterBottom variant="subtitle2">
        {title}
      </Typography>
      <Divider />
      <Typography
        className="tile-description"
        gutterBottom
        variant="body2"
        color="text.secondary"
      >
        {description}
      </Typography>
      <Typography
        className="tile-dots"
        gutterBottom
        variant="body2"
        color="text.secondary"
      >
        ...
      </Typography>
    </div>
    <div className="tile-actions">
      <IconButton>
        <IoExpandSharp title="Expand" />
      </IconButton>
      <IconButton>
        <AiFillLike title="Vote up" />
      </IconButton>
      <IconButton>
        <IoBug title="Report bug" />
      </IconButton>
    </div>
  </Paper>
);

export default styled(Tile)`
  & {
    display: grid;
    grid-template-columns: calc(100% - 45px) 45px;
    grid-auto-flow: row;
    height: 200px;
    padding: 10px 0 10px 10px;

    .tile-content {
      .MuiDivider-root {
        margin: 8px 0;
      }

      .tile-dots {
        line-height: 0.5em;
        height: 0.5em;
      }

      .tile-title,
      .tile-description {
        line-height: 1.5em;
        overflow: hidden;
        text-overflow: ellipsis;
      }

      .tile-title {
        height: 4.5em;
      }

      .tile-description {
        height: 6em;
      }
    }

    .tile-actions {
      display: flex;
      flex-direction: column;
    }
  }
`;

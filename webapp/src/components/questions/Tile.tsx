import { type Props } from "@/models/props";
import {
  Button,
  Card,
  CardActions,
  CardContent,
  Typography,
  styled,
} from "@mui/material";

interface ITileProps {
  title: string;
  description?: string;
}

const Tile = ({ className, title, description }: Props<ITileProps>) => (
  <Card className={className}>
    <CardContent sx={{ height: "80%" }}>
      <Typography gutterBottom variant="subtitle1" noWrap={false}>
        {title}
      </Typography>
      <Typography variant="body2" color="text.secondary">
        {description}
      </Typography>
    </CardContent>
    <CardActions sx={{ height: "20%" }}>
      <Button size="small">Learn More</Button>
    </CardActions>
  </Card>
);

export default styled(Tile)`
  & {
    height: 200px;
  }
`;

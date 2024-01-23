import { type Props } from "@/models/props";
import { ordersAtom } from "@/store/organizer";
import {
  List,
  ListItem,
  ListItemIcon,
  ListItemText,
  Switch,
  styled,
} from "@mui/material";
import { useAtom } from "jotai";
import { IoMdRefresh } from "react-icons/io";

const Offers = ({ className }: Props) => {
  const [{ data }] = useAtom(ordersAtom);

  return (
    <List className={className}>
      {data?.map((o) => (
        <ListItem key={o.name}>
          <ListItemIcon>
            <IoMdRefresh />
          </ListItemIcon>
          <ListItemText id="switch-list-label-wifi" primary={o.name} />
          <Switch
            edge="end"
            inputProps={{
              "aria-labelledby": "switch-list-label-wifi",
            }}
          />
        </ListItem>
      ))}
    </List>
  );
};

export default styled(Offers)`
  & {
    width: 100%;
    background-color: var(--color-gray-0);
  }
`;

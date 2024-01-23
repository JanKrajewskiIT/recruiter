import AddOffer from "@/components/organizer/AddOffer";
import { type Props } from "@/models/props";
import { offersAtom, selectedStatus } from "@/store/organizer";
import {
  List,
  ListItem,
  ListItemIcon,
  ListItemText,
  styled,
} from "@mui/material";
import { useAtom } from "jotai";
import { RxDragHandleDots1 } from "react-icons/rx";

const entryStatusValue = "New";

const Offers = ({ className }: Props) => {
  const [{ data }] = useAtom(offersAtom);
  const [status] = useAtom(selectedStatus);

  return (
    <div className={className}>
      {!!data?.length && (
        <List>
          {data?.map((o) => (
            <ListItem key={o.id} disablePadding>
              <ListItemIcon>
                <RxDragHandleDots1 />
              </ListItemIcon>
              <ListItemText primary={o.name} />
            </ListItem>
          ))}
        </List>
      )}
      {status === entryStatusValue && <AddOffer />}
    </div>
  );
};

export default styled(Offers)`
  & {
    .MuiList-root {
      width: 100%;
      background-color: var(--color-gray-0);

      .MuiListItemIcon-root {
        display: flex;
        justify-content: center;
        min-width: 40px;
        cursor: pointer;

        > svg {
          font-size: 1.5em;
        }
      }
    }

    .MuiButtonBase-root {
      margin-top: 20px;
    }
  }
`;

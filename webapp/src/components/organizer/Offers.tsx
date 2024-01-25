import AddOffer from "@/components/organizer/AddOffer";
import { type Props } from "@/models/props";
import {
  offersAtom,
  selectedStatus,
  useDeleteOfferMutation,
} from "@/store/organizer";
import {
  IconButton,
  List,
  ListItem,
  ListItemIcon,
  ListItemSecondaryAction,
  ListItemText,
  ListSubheader,
  styled,
} from "@mui/material";
import { useAtom } from "jotai";
import { useCallback } from "react";
import { MdDelete, MdEdit } from "react-icons/md";
import { RxDragHandleDots1, RxExternalLink } from "react-icons/rx";

const entryStatusValue = "New";

const Offers = ({ className }: Props) => {
  const [{ data }] = useAtom(offersAtom);
  const [status] = useAtom(selectedStatus);
  const { mutate } = useDeleteOfferMutation();

  return (
    <div className={className}>
      {!!data?.length && (
        <List
          subheader={
            <ListSubheader>
              <span>Tytuł stanowiska</span>
              <span>Nazwa firmy</span>
              <span>Miasto</span>
              <span>Akcje</span>
            </ListSubheader>
          }
        >
          {data?.map((o) => (
            <ListItem key={o.id}>
              <ListItemIcon>
                <RxDragHandleDots1 />
              </ListItemIcon>
              <ListItemText primary={o.name} />
              <ListItemText primary={o.company} />
              <ListItemText primary={o.city} />
              <ListItemSecondaryAction>
                <IconButton
                  edge="end"
                  aria-label="link"
                  onClick={() => window.open(o.link)}
                >
                  <RxExternalLink />
                </IconButton>
                <IconButton edge="end" aria-label="edit">
                  <MdEdit />
                </IconButton>
                <IconButton
                  edge="end"
                  aria-label="delete"
                  onClick={() => mutate(o.id)}
                >
                  <MdDelete />
                </IconButton>
              </ListItemSecondaryAction>
            </ListItem>
          ))}
        </List>
      )}
      {status === entryStatusValue && <AddOffer className="add-offer" />}
    </div>
  );
};

export default styled(Offers)`
  & {
    display: flex;
    flex-direction: column;
    align-items: end;

    .MuiList-root {
      width: 100%;
      padding: 0;

      .MuiListSubheader-root {
        display: grid;
        grid-template-columns: 71.5% 12.5% 12% 4%;
        padding: 0 40px;
        background-color: transparent;
      }

      .MuiListItem-root {
        background-color: var(--color-gray-0);
        padding: 5px 0;
        margin-bottom: 8px;
        display: grid;
        grid-template-columns: 40px calc(70% - 40px) calc(15% - 40px) calc(
            15% - 40px
          );

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
    }
  }
`;

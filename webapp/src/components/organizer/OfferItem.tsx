import ChangeStatus from "@/components/organizer/ChangeStatus";
import DeleteOffer from "@/components/organizer/DeleteOffer";
import UpdateOffer from "@/components/organizer/UpdateOffer";
import RedirectToOffer from "@/components/organizer/RedirectToOffer";
import { type Props } from "@/models/props";
import { type Offer } from "@/store/organizer";
import {
  ListItem,
  ListItemIcon,
  ListItemSecondaryAction,
  ListItemText,
  styled,
} from "@mui/material";
import { RxDragHandleDots1 } from "react-icons/rx";

interface IOfferItemProps {
  offer: Offer;
}

const OfferItem = ({ className, offer }: Props<IOfferItemProps>) => {
  const { id, name, link, company, city } = offer;

  return (
    <ListItem className={className}>
      <ListItemIcon>
        <RxDragHandleDots1 />
      </ListItemIcon>
      <ListItemText primary={name} />
      <ListItemText primary={company} />
      <ListItemText primary={city} />
      <ChangeStatus offerId={id} />
      <ListItemSecondaryAction>
        <RedirectToOffer link={link} />
        <UpdateOffer offer={offer} />
        <DeleteOffer offerId={id} />
      </ListItemSecondaryAction>
    </ListItem>
  );
};

export default styled(OfferItem)`
  & {
    background-color: var(--color-gray-0);
    padding: 2px 0;
    margin-bottom: 8px;
    display: grid;
    grid-template-columns:
      40px
      calc(55% - 40px)
      calc(15% - 40px)
      calc(15% - 40px)
      calc(15% - 40px);

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
`;

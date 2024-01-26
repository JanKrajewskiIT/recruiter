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
  listItemIconClasses,
  styled,
} from "@mui/material";
import { RxDragHandleDots1 } from "react-icons/rx";
import { Atom, useAtom } from "jotai";

interface IOfferItemProps {
  atom: Atom<Offer>;
}

const OfferItem = ({ className, atom }: Props<IOfferItemProps>) => {
  const [offer] = useAtom(atom);
  const { id, name, link, company, city } = offer;
  console.log(offer);
  return (
    <ListItem className={className}>
      <ListItemIcon>
        <RxDragHandleDots1 />
      </ListItemIcon>
      <ListItemText primary={name} />
      <ListItemText secondary={company} />
      <ListItemText secondary={city} />
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
    grid-template-columns: 40px 1fr 1fr 120px 140px 120px;

    .${listItemIconClasses.root} {
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
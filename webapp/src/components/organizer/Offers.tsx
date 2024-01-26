import AddOffer from "@/components/organizer/AddOffer";
import OfferItem from "@/components/organizer/OfferItem";
import { type Props } from "@/models/props";
import { dataLength, offersAtom, selectedStatus, splittedOffersAtom } from "@/store/organizer";
import {
  List,
  ListSubheader,
  listClasses,
  listSubheaderClasses,
  styled,
} from "@mui/material";
import { useAtom } from "jotai";

const entryStatusValue = "New";

const Offers = ({ className }: Props) => {
  const [offersAtom] = useAtom(splittedOffersAtom);
  const [status] = useAtom(selectedStatus);

  return (
    <div className={className}>
      {!!offersAtom.length && (
        <List
          subheader={
            <ListSubheader>
              <span>Tytuł stanowiska</span>
              <span>Nazwa firmy</span>
              <span>Miasto</span>
              <span>Status</span>
            </ListSubheader>
          }
        >
          {offersAtom.map((o) => <OfferItem atom={o} key={o.toString()} />)}
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
    align-items: start;

    .${listClasses.root} {
      width: 100%;
      padding: 0;

      .${listSubheaderClasses.root} {
        display: grid;
        grid-template-columns: 1fr 1fr 120px 220px;
        padding: 0 40px;
        background-color: transparent;
      }
    }
  }
`;

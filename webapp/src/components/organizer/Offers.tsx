import AddOffer from "@/components/organizer/AddOffer";
import OfferItem from "@/components/organizer/OfferItem";
import { type Props } from "@/models/props";
import { offersAtom, selectedStatus } from "@/store/organizer";
import { List, ListSubheader, styled } from "@mui/material";
import { useAtom } from "jotai";

const entryStatusValue = "New";

const Offers = ({ className }: Props) => {
  const [{ data }] = useAtom(offersAtom);
  const [status] = useAtom(selectedStatus);

  return (
    <div className={className}>
      {!!data?.length && (
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
          {data?.map((o) => <OfferItem key={o.id} offer={o} />)}
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

    .MuiList-root {
      width: 100%;
      padding: 0;

      .MuiListSubheader-root {
        display: grid;
        grid-template-columns: 55.5% 12.5% 12% 20%;
        padding: 0 40px;
        background-color: transparent;
      }
    }
  }
`;

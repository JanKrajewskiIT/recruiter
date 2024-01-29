import AddOffer from "@/components/organizer/AddOffer";
import OfferItem from "@/components/organizer/OfferItem";
import OfferStatus from "@/models/OfferStatus";
import { type Props } from "@/models/props";
import {
  offersLengthAtom,
  selectedStatusAtom,
  splitOffersAtom,
} from "@/store/organizer";
import { Typography, styled } from "@mui/material";
import { useAtom } from "jotai";
import { Fragment } from "react";

const Offers = ({ className }: Props) => {
  const [offersAtom] = useAtom(splitOffersAtom);
  const [offersLength] = useAtom(offersLengthAtom);
  const [status] = useAtom(selectedStatusAtom);

  return (
    <div className={className}>
      {!!offersLength && (
        <Fragment>
          <div className="list-headers">
            <Typography variant="subtitle2" color="text.secondary">
              Tytuł stanowiska
            </Typography>
            <Typography variant="subtitle2" color="text.secondary">
              Nazwa firmy
            </Typography>
            <Typography variant="subtitle2" color="text.secondary">
              Miasto
            </Typography>
            <Typography variant="subtitle2" color="text.secondary">
              Status
            </Typography>
          </div>
          {offersAtom.map((o) => (
            <OfferItem key={o.toString()} offerAtom={o} />
          ))}
        </Fragment>
      )}
      {status === OfferStatus.New && <AddOffer className="add-offer" />}
    </div>
  );
};

export default styled(Offers)`
  & {
    .list-headers {
      display: grid;
      grid-template-columns: 1fr 1fr 136px 258px;
      padding-left: 46px;
      margin-bottom: 14px;
      width: 100%;
    }

    > button {
      margin-top: 6px;
    }
  }
`;

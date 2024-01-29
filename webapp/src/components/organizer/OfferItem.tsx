import ChangeStatus from "@/components/organizer/ChangeStatus";
import DeleteOffer from "@/components/organizer/DeleteOffer";
import UpdateOffer from "@/components/organizer/UpdateOffer";
import RedirectToOffer from "@/components/organizer/RedirectToOffer";
import { type Props } from "@/models/props";
import {
  styled,
  Accordion,
  AccordionSummary,
  AccordionDetails,
  accordionSummaryClasses,
  AccordionActions,
  Typography,
  accordionActionsClasses,
  typographyClasses,
  Chip,
  accordionDetailsClasses,
} from "@mui/material";
import { type Atom, useAtom } from "jotai";
import type Offer from "@/models/Offer";
import { MdExpandMore } from "react-icons/md";

interface IOfferItemProps {
  offerAtom: Atom<Offer>;
}

const OfferItem = ({ className, offerAtom }: Props<IOfferItemProps>) => {
  const [offer] = useAtom(offerAtom);
  const { id, name, link, company, city } = offer;

  return (
    <Accordion className={className} elevation={0}>
      <AccordionSummary expandIcon={<MdExpandMore />}>
        <Typography variant="body2">{name}</Typography>
        <Typography variant="body2" color="text.secondary">
          {company}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {city}
        </Typography>
        <AccordionActions onClick={(e) => e.stopPropagation()}>
          <ChangeStatus offer={offer} />
          <RedirectToOffer link={link} />
          <UpdateOffer offer={offer} />
          <DeleteOffer offerId={id} />
        </AccordionActions>
      </AccordionSummary>
      <AccordionDetails>
        <Typography variant="subtitle2">Powody</Typography>
        <div className="reason-tiles">
          {offer.reasons.map((r) => (
            <Chip key={r} label={r} />
          ))}
        </div>
      </AccordionDetails>
    </Accordion>
  );
};

export default styled(OfferItem)`
  & {
    width: 100%;
    margin-bottom: 4px;

    .${accordionSummaryClasses.root} {
      flex-direction: row-reverse;

      .${accordionSummaryClasses.content} {
        display: grid;
        grid-template-columns: 1fr 1fr 120px 260px;
        margin: 0;
        padding-left: 14px;

        .${typographyClasses.root} {
          display: flex;
          flex-direction: column;
          justify-content: center;
        }
      }

      .${accordionActionsClasses.root} {
        padding: 0;
      }
    }

    .${accordionDetailsClasses.root} {
      display: grid;
      grid-template-columns: 60px 1fr;
      padding: 14px 46px;

      .reason-tiles > * {
        margin-left: 4px;
      }

      .${typographyClasses.root} {
        display: flex;
        align-items: center;
      }
    }
  }
`;

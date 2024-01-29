import FormDialog from "@/components/common/FormDialog";
import MultipleAutocomplete from "@/components/common/MultipleAutocomplete";
import ReasonsAutocomplete from "@/components/organizer/ReasonsAutocomplete";
import type Offer from "@/models/Offer";
import type OfferState from "@/models/OfferState";
import type OfferStatus from "@/models/OfferStatus";
import { type Props } from "@/models/props";
import { reasonsAtom } from "@/store/dictionary";
import { useAtom } from "jotai";
import { useCallback, useState } from "react";

interface IChangeStateDialogProps {
  open: boolean;
  offer: Offer;
  status: OfferStatus;
  onClose: () => void;
  onSubmit: (state: OfferState) => void;
}

const ChangeStateDialog = ({
  className,
  open,
  offer,
  status,
  onClose,
  onSubmit,
}: Props<IChangeStateDialogProps>) => {
  const [reasons, setReasons] = useState(offer?.reasons);

  const handleStateChange = useCallback(
    (state: OfferState) =>
      onSubmit({ ...state, id: offer.id, status, reasons }),
    [offer.id, onSubmit, reasons, status],
  );

  return (
    <FormDialog
      className={className}
      open={open}
      title="Zmiana statusu"
      description={`
        Zmiana statusu wymaga powodu zaakceptowania bądź odrzucenia oferty. 
        Może być ich więcej niż jeden.`}
      submitTitle="Zmień"
      onClose={onClose}
      onSubmit={handleStateChange}
    >
      <ReasonsAutocomplete reasons={reasons} onReasonsChange={setReasons} />
    </FormDialog>
  );
};

export default ChangeStateDialog;

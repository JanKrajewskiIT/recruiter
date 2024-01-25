import AddOfferDialog from "@/components/organizer/DefineOfferDialog";
import { type Props } from "@/models/props";
import { type Offer, useUpdateOfferMutation } from "@/store/organizer";
import { IconButton } from "@mui/material";
import { Fragment, useCallback, useState } from "react";
import { MdEdit } from "react-icons/md";

interface IEditOfferProps {
  offer: Offer;
}

const EditOffer = ({ className, offer }: Props<IEditOfferProps>) => {
  const [open, setOpen] = useState(false);
  const { mutate } = useUpdateOfferMutation();

  const handleOpen = useCallback(() => setOpen(true), []);
  const handleClose = useCallback(() => setOpen(false), []);
  const handleSubmit = useCallback(
    (newOffer: Offer) => mutate({ ...newOffer, id: offer.id }),
    [mutate, offer],
  );

  return (
    <Fragment>
      <IconButton className={className} edge="end" onClick={handleOpen}>
        <MdEdit />
      </IconButton>
      <AddOfferDialog
        open={open}
        offer={offer}
        title="Edycja oferty"
        submitTitle="Edytuj"
        onClose={handleClose}
        onSubmit={handleSubmit}
      />
    </Fragment>
  );
};

export default EditOffer;

import AddOfferDialog from "@/components/organizer/DefineOfferDialog";
import { type Props } from "@/models/props";
import { type Offer, useUpdateOfferMutation } from "@/store/organizer";
import { IconButton } from "@mui/material";
import { Fragment, useCallback, useState } from "react";
import { MdEdit } from "react-icons/md";

interface IUpdateOfferProps {
  offer: Offer;
}

const UpdateOffer = ({ className, offer }: Props<IUpdateOfferProps>) => {
  const [open, setOpen] = useState(false);
  const { mutate } = useUpdateOfferMutation();

  const handleOpen = useCallback(() => setOpen(true), []);
  const handleClose = useCallback(() => setOpen(false), []);
  const handleUpdate = useCallback(
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
        onSubmit={handleUpdate}
      />
    </Fragment>
  );
};

export default UpdateOffer;

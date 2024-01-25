import AddOfferDialog from "@/components/organizer/DefineOfferDialog";
import { type Props } from "@/models/props";
import { useAddOfferMutation, type Offer } from "@/store/organizer";
import { Button } from "@mui/material";
import { Fragment, useCallback, useState } from "react";
import { IoAddSharp } from "react-icons/io5";

const AddOffer = ({ className }: Props) => {
  const [open, setOpen] = useState(false);
  const { mutate } = useAddOfferMutation();

  const handleOpen = useCallback(() => setOpen(true), []);
  const handleClose = useCallback(() => setOpen(false), []);
  const handleSubmit = useCallback((offer: Offer) => mutate(offer), [mutate]);

  return (
    <Fragment>
      <Button
        className={className}
        startIcon={<IoAddSharp />}
        variant="outlined"
        onClick={handleOpen}
      >
        Nowa oferta
      </Button>
      <AddOfferDialog
        open={open}
        title="Dodawanie oferty"
        submitTitle="Dodaj"
        onClose={handleClose}
        onSubmit={handleSubmit}
      />
    </Fragment>
  );
};

export default AddOffer;

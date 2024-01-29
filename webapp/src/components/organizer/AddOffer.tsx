import AddOfferDialog from "@/components/organizer/DefineOfferDialog";
import type Offer from "@/models/Offer";
import { type Props } from "@/models/props";
import { useAddOfferMutation } from "@/store/organizer";
import { Button } from "@mui/material";
import { Fragment, useCallback, useState } from "react";
import { IoAddSharp } from "react-icons/io5";

const AddOffer = ({ className }: Props) => {
  const [open, setOpen] = useState(false);
  const { mutate } = useAddOfferMutation();

  const handleOpen = useCallback(() => setOpen(true), []);
  const handleClose = useCallback(() => setOpen(false), []);
  const handleAdd = useCallback((offer: Offer) => mutate(offer), [mutate]);

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
        onSubmit={handleAdd}
      />
    </Fragment>
  );
};

export default AddOffer;

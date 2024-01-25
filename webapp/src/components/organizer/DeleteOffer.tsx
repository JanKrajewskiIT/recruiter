import { type Props } from "@/models/props";
import { useDeleteOfferMutation } from "@/store/organizer";
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  IconButton,
} from "@mui/material";
import { Fragment, useCallback, useState } from "react";
import { MdDelete } from "react-icons/md";

interface IDeleteOfferProps {
  offerId: string;
}

const DeleteOffer = ({ className, offerId }: Props<IDeleteOfferProps>) => {
  const [open, setOpen] = useState(false);
  const { mutate } = useDeleteOfferMutation();

  const handleOpen = useCallback(() => setOpen(true), []);
  const handleClose = useCallback(() => setOpen(false), []);
  const handleRemove = useCallback(() => {
    mutate(offerId);
    handleClose();
  }, [handleClose, mutate, offerId]);

  return (
    <Fragment>
      <IconButton className={className} edge="end" onClick={handleOpen}>
        <MdDelete />
      </IconButton>
      <Dialog open={open} onClose={handleClose}>
        <DialogTitle>Usuwanie oferty</DialogTitle>
        <DialogContent>
          <DialogContentText>
            Zmiany, których próbujesz dokonać będą nieodwracalne. Czy jesteś ich
            pewien ?
          </DialogContentText>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>Anuluj</Button>
          <Button onClick={handleRemove} autoFocus>
            Usuń
          </Button>
        </DialogActions>
      </Dialog>
    </Fragment>
  );
};

export default DeleteOffer;

import { type Props } from "@/models/props";
import { type Offer, useOffersMutation } from "@/store/organizer";
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
  TextField,
  styled,
} from "@mui/material";
import { type FormEvent, Fragment, useCallback, useState } from "react";
import { IoAddSharp } from "react-icons/io5";

const AddOffer = ({ className }: Props) => {
  const [open, setOpen] = useState(false);
  const { mutate } = useOffersMutation();

  const handleClickOpen = useCallback(() => setOpen(true), []);
  const handleClose = useCallback(() => setOpen(false), []);
  const handleSubmit = useCallback(
    (event: FormEvent<HTMLFormElement>) => {
      event.preventDefault();
      const formData = new FormData(event.currentTarget);
      const offer = Object.fromEntries(formData.entries()) as unknown as Offer;
      mutate(offer);
      handleClose();
    },
    [handleClose, mutate],
  );

  return (
    <Fragment>
      <Button
        className={className}
        startIcon={<IoAddSharp />}
        variant="outlined"
        onClick={handleClickOpen}
      >
        Nowa oferta
      </Button>
      <Dialog
        open={open}
        onClose={handleClose}
        PaperProps={{
          component: "form",
          onSubmit: handleSubmit,
        }}
      >
        <DialogTitle>Nowa oferta</DialogTitle>
        <DialogContent>
          <TextField
            autoFocus
            required
            margin="dense"
            id="name"
            name="name"
            label="Tytuł stanowiska"
            type="text"
            fullWidth
            variant="standard"
          />
          <TextField
            autoFocus
            required
            margin="dense"
            id="link"
            name="link"
            label="Link do szczegółów oferty"
            type="url"
            fullWidth
            variant="standard"
          />
          <TextField
            autoFocus
            required
            margin="dense"
            id="company"
            name="company"
            label="Nazwa firmy"
            type="text"
            fullWidth
            variant="standard"
          />
          <TextField
            autoFocus
            required
            margin="dense"
            id="city"
            name="city"
            label="Miasto"
            type="text"
            fullWidth
            variant="standard"
          />
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>Anuluj</Button>
          <Button type="submit">Dodaj</Button>
        </DialogActions>
      </Dialog>
    </Fragment>
  );
};

export default styled(AddOffer)`
  & {
  }
`;

import { type Props } from "@/models/props";
import { type Offer } from "@/store/organizer";
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
} from "@mui/material";
import { type FormEvent, useCallback } from "react";

interface IDefineOfferDialogProps {
  open: boolean;
  offer?: Offer;
  title: string;
  submitTitle: string;
  onClose: () => void;
  onSubmit: (offer: Offer) => void;
}

const DefineOfferDialog = ({
  className,
  open,
  offer,
  title,
  submitTitle,
  onClose,
  onSubmit,
}: Props<IDefineOfferDialogProps>) => {
  const handleSubmit = useCallback(
    (event: FormEvent<HTMLFormElement>) => {
      event.preventDefault();
      const formData = new FormData(event.currentTarget);
      const offer = Object.fromEntries(formData.entries()) as unknown as Offer;
      onSubmit(offer);
      onClose();
    },
    [onClose, onSubmit],
  );

  return (
    <Dialog
      className={className}
      open={open}
      onClose={onClose}
      PaperProps={{
        component: "form",
        onSubmit: handleSubmit,
      }}
    >
      <DialogTitle>{title}</DialogTitle>
      <DialogContent>
        <DialogContentText>
          Wymagane jest podanie wszystkich informacji tj. tytułu stanowiska,
          linku do oferty, nazwy firmy rekrutującej a także miasta, którego ta
          oferta dotyczy. W przypadku oferty zdalnej można zamiast miasta wpisać
          &apos;Remote&apos;.
        </DialogContentText>
        <TextField
          autoFocus
          required
          defaultValue={offer?.name}
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
          defaultValue={offer?.link}
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
          defaultValue={offer?.company}
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
          defaultValue={offer?.city}
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
        <Button onClick={onClose}>Anuluj</Button>
        <Button type="submit">{submitTitle}</Button>
      </DialogActions>
    </Dialog>
  );
};

export default DefineOfferDialog;

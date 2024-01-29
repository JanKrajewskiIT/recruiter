import { type Props } from "@/models/props";
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  dialogContentTextClasses,
  styled,
} from "@mui/material";
import { type FormEvent, useCallback } from "react";

interface IFormDialogProps<TModel = void> {
  open: boolean;
  title: string;
  description: string;
  submitTitle: string;
  onClose: () => void;
  onSubmit: (offer: TModel) => void;
}

const FormDialog = <TModel,>({
  className,
  children,
  open,
  title,
  description,
  submitTitle,
  onClose,
  onSubmit,
}: Props<IFormDialogProps<TModel>>) => {
  const handleSubmit = useCallback(
    (event: FormEvent<HTMLFormElement>) => {
      event.preventDefault();
      const formData = new FormData(event.currentTarget);
      const model = Object.fromEntries(formData.entries()) as unknown as TModel;
      onSubmit(model);
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
        <DialogContentText>{description}</DialogContentText>
        {children}
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Anuluj</Button>
        <Button type="submit">{submitTitle}</Button>
      </DialogActions>
    </Dialog>
  );
};

export default styled(FormDialog)`
  & {
    .${dialogContentTextClasses.root} {
      margin-bottom: 20px;
    }
  }
` as typeof FormDialog;

import { type Props } from "@/models/props";
import { TextField, type TextFieldProps } from "@mui/material";

const InputText = ({
  className,
  name,
  label,
  type = "text",
  defaultValue,
  required = true,
  ...props
}: Props<TextFieldProps>) => (
  <TextField
    className={className}
    {...props}
    id={name}
    name={name}
    label={label}
    type={type}
    defaultValue={defaultValue}
    required={required}
    autoFocus
    fullWidth
    margin="dense"
    size="small"
  />
);

export default InputText;

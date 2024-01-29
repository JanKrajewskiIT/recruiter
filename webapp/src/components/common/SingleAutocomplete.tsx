import InputText from "@/components/common/InputText";
import { type Props } from "@/models/props";
import { Autocomplete, type TextFieldProps } from "@mui/material";
import { type ComponentProps } from "react";

type ISingleAutocompleteProps = Pick<
  ComponentProps<typeof Autocomplete>,
  "options" | "defaultValue"
> &
  Pick<TextFieldProps, "name" | "label">;

const SingleAutocomplete = ({
  className,
  options,
  defaultValue,
  name,
  label,
}: Props<ISingleAutocompleteProps>) => (
  <Autocomplete
    className={className}
    options={options}
    clearOnEscape
    defaultValue={defaultValue}
    renderInput={(params) => (
      <InputText {...params} id={name} name={name} label={label} />
    )}
    componentsProps={{
      popper: {
        modifiers: [
          {
            name: "flip",
            enabled: false,
          },
          {
            name: "preventOverflow",
            enabled: false,
          },
        ],
      },
    }}
    ListboxProps={{
      style: {
        height: "190px",
      },
    }}
  />
);

export default SingleAutocomplete;

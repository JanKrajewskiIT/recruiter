import InputText from "@/components/common/InputText";
import { type Props } from "@/models/props";
import { Autocomplete, type TextFieldProps } from "@mui/material";
import { type ComponentProps } from "react";

interface IMultipleAutocompleteProps
  extends Pick<ComponentProps<typeof Autocomplete>, "options">,
    Pick<TextFieldProps, "name" | "label" | "value"> {
  value: string[];
  onValueChange: (value: string[]) => void;
}

const MultipleAutocomplete = ({
  className,
  options,
  value,
  name,
  label,
  onValueChange,
}: Props<IMultipleAutocompleteProps>) => (
  <Autocomplete
    className={className}
    multiple
    filterSelectedOptions
    options={options}
    clearOnEscape
    value={value}
    onChange={(_, newValue) => onValueChange(newValue as [])}
    renderInput={(params) => (
      <InputText
        {...params}
        id={name}
        name={name}
        label={label}
        required={value?.length === 0}
      />
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

export default MultipleAutocomplete;

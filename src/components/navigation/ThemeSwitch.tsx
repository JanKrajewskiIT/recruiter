import { MdDarkMode, MdLightMode } from "react-icons/md";
import { styled, Switch } from "@mui/material";
import { type Props } from "@/models/props";

interface IThemeSwitchProps {
  isDarkMode: boolean;
  setDarkMode: (isDarkMode: boolean) => void;
}

const ThemeSwitch = ({
  className,
  isDarkMode,
  setDarkMode,
}: Props<IThemeSwitchProps>) => {
  const handleChange = (_: unknown, checked: boolean) => {
    setDarkMode(checked);
  };

  return (
    <Switch
      className={className}
      checked={isDarkMode}
      icon={<MdLightMode fontSize="small" />}
      checkedIcon={<MdDarkMode fontSize="small" />}
      onChange={handleChange}
    />
  );
};

export default styled(ThemeSwitch)`
  & {
    width: 52px;
    height: 32px;
    padding: 6px;

    .MuiButtonBase-root,
    .MuiButtonBase-root:hover,
    .MuiButtonBase-root.Mui-checked:hover {
      background-color: ${({ theme }) =>
        theme.palette.mode === "dark" ? "#003892" : "#001e3c"};
      width: 32px;
      height: 32px;
    }

    .MuiSwitch-track {
      opacity: 1;
      background-color: ${({ theme }) =>
        theme.palette.mode === "dark" ? "#8796A5" : "#aab4be"};
      border-radius: 15px;
    }

    .MuiSvgIcon-root {
      color: white;
    }
  }
`;

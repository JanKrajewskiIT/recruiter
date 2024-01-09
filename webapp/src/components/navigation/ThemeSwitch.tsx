import { MdDarkMode, MdLightMode } from "react-icons/md";
import { styled } from "@mui/material";
import { isDarkModeAtom } from "@/store/theme";
import { useAtom } from "jotai";
import { type Props } from "@/models/props";
import { palette } from "@/components/theme/theme";

const ThemeSwitch = ({ className }: Props) => {
  const [isDarkMode, setDarkMode] = useAtom(isDarkModeAtom);
  const handleChange = (checked: boolean) => () => {
    setDarkMode(checked);
  };

  return (
    <div className={className}>
      <div
        className={`switch ${isDarkMode ? "" : "active"}`}
        onClick={handleChange(false)}
      >
        <MdLightMode />
      </div>
      <div className="spacer" />
      <div
        className={`switch ${isDarkMode ? "active" : ""}`}
        onClick={handleChange(true)}
      >
        <MdDarkMode />
      </div>
    </div>
  );
};

export default styled(ThemeSwitch)`
  & {
    --icon-color: ${(props) =>
      props.theme.isDarkMode
        ? props.theme.palette.background.default
        : palette.brand};

    display: flex;
    align-items: center;

    .switch {
      display: flex;
      align-items: center;
      justify-content: center;
      width: 28px;
      height: 28px;
      background-color: var(--icon-color);
      border: 2px solid var(--color-gray-10);
      border-radius: 50%;
      cursor: pointer;
      z-index: 2;
      transition: transform 1s;
    }

    .switch.active {
      transform: scale(1.4);
      background-color: var(--color-gray-10);
      color: var(--icon-color);
      z-index: 1;
      transition: transform 1s;
    }

    .spacer::before,
    .spacer::after {
      content: "";
      position: absolute;
      width: 5px;
      height: 5px;
      z-index: 0;
      transition: 1s;
    }

    .spacer::before {
      margin-top: -15.5px;
      margin-left: ${(props) => (props.theme.isDarkMode ? "-6.2px" : "1.2px")};
      border-bottom-left-radius: 50%;
      box-shadow: -4px 4px 1px 3px var(--color-gray-10);
      transform: rotate(
        ${(props) => (props.theme.isDarkMode ? "-60deg" : "-30deg")}
      );
    }

    .spacer::after {
      margin-top: 11px;
      margin-left: ${(props) => (props.theme.isDarkMode ? "-6.2px" : "1.2px")};
      border-top-left-radius: 50%;
      box-shadow: -4px -4px 1px 3px var(--color-gray-10);
      transform: rotate(
        ${(props) => (props.theme.isDarkMode ? "60deg" : "30deg")}
      );
    }
  }
`;

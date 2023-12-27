import { MdDarkMode, MdLightMode } from "react-icons/md";
import { styled } from "@mui/material";
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
    display: flex;
    align-items: center;

    .switch {
      display: flex;
      align-items: center;
      justify-content: center;
      width: 28px;
      height: 28px;
      background-color: var(--nav-background);
      border: 2px solid var(--color-gray-0);
      border-radius: 30px;
      z-index: 1;
      transition: transform 1s;
    }

    .switch.active {
      transform: scale(1.4);
      background-color: var(--color-gray-0);
      color: var(--nav-background);
      z-index: 0;
      transition: transform 1s;
    }

    .spacer::before,
    .spacer::after {
      content: "";
      position: absolute;
      width: 10px;
      height: 10px;
      border-radius: 15px;
      margin-left: ${(props) => (props.isDarkMode ? "-9px" : "-1px")};
      transition: 1s;
    }

    .spacer::before {
      border-bottom: 2px solid var(--color-gray-0);
      margin-top: -18.4px;
      transform: rotate(${(props) => (props.isDarkMode ? "-10deg" : "10deg")});
    }

    .spacer::after {
      border-top: 2px solid var(--color-gray-0);
      margin-top: 8.6px;
      transform: rotate(${(props) => (props.isDarkMode ? "10deg" : "-10deg")});
    }
  }
`;

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
    flex-direction: row;
    align-items: center;

    .switch {
      display: flex;
      align-items: center;
      justify-content: center;
      width: 28px;
      height: 28px;
      background-color: var(--nav-background);
      border: 1.5px solid white;
      border-radius: 30px;
      transition: 1s;
      z-index: 1;
    }

    .switch.active {
      transform: scale(1.5);
      background-color: white;
      color: var(--nav-background);
      transition: 1s;
      z-index: -1;
    }

    .spacer {
      display: flex;
      z-index: -1;
    }

    .spacer::before {
      content: "";
      position: absolute;
      border-radius: 15px;
      margin-top: -21.5px;
      margin-left: ${(props) => (props.isDarkMode ? "-10px" : "-0px")};
      width: 10px;
      height: 10px;
      border-bottom: 2px solid white;
      transform: rotate(${(props) => (props.isDarkMode ? "-12deg" : "12deg")});
      transition: 1s;
      z-index: -1;
    }

    .spacer::after {
      content: "";
      position: absolute;
      border-radius: 15px;
      margin-top: 10px;
      margin-left: ${(props) => (props.isDarkMode ? "-10px" : "-0px")};
      width: 10px;
      height: 10px;
      border-top: 2px solid white;
      transform: rotate(${(props) => (props.isDarkMode ? "12deg" : "-12deg")});
      transition: 1s;
      z-index: -1;
    }
  }
`;

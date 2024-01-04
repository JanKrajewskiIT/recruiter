import { palette } from "@/components/theme/theme";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";

interface IMenuIndicatorProps {
  offset: number;
}

const MenuIndicator = ({ className }: Props<IMenuIndicatorProps>) => (
  <div className={className}>
    <span></span>
  </div>
);

export default styled(MenuIndicator)`
  & {
    --background-color: ${(props) => props.theme.palette.background.default};
    --indicator-color: ${(props) =>
      props.theme.isDarkMode ? palette.colorGray20 : palette.brand};

    top: 6px;
    position: absolute;
    display: flex;
    align-items: center;
    justify-content: center;
    width: var(--header-height);
    height: var(--header-height);
    border-top-left-radius: 35px;
    border-top-right-radius: 35px;
    background: var(--background-color);
    transform: translateX(
      calc(var(--header-height) * ${(props) => props.offset})
    );
    transition: transform 0.5s;

    &::before,
    &::after {
      content: "";
      position: absolute;
      top: 35px;
      width: 20px;
      height: 20px;
    }

    &::before {
      left: -19.2px;
      border-bottom-right-radius: 20px;
      box-shadow: 6px 8px 4px 2px var(--background-color);
    }

    &::after {
      right: -19.2px;
      border-bottom-left-radius: 20px;
      box-shadow: -6px 8px 4px 2px var(--background-color);
    }

    span {
      width: 44px;
      height: 44px;
      border: 2.5px solid var(--indicator-color);
      background: var(--background-color);
      border-radius: 50%;
    }
  }
`;

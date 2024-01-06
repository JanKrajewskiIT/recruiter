import MenuIndicator from "@/components/navigation/MenuIndicator";
import MenuItem from "@/components/navigation/MenuItem";
import { navItems } from "@/components/navigation/NavItem";
import { palette } from "@/components/theme/theme";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";
import { useCallback } from "react";

interface IMenuBarProps {
  activeIndex: number;
  setActiveIndex: (active: number) => void;
}

const MenuBar = ({
  className,
  activeIndex,
  setActiveIndex,
}: Props<IMenuBarProps>) => {
  const handleActiveChange = useCallback(
    (activeIndex: number) => () => {
      setActiveIndex(activeIndex);
    },
    [setActiveIndex],
  );

  return (
    <ul className={className}>
      {navItems.map(({ name, href, icon }, index) => (
        <MenuItem
          key={name}
          className={activeIndex === index ? "active" : ""}
          href={href}
          icon={icon}
          onClick={handleActiveChange(index)}
        />
      ))}
      <MenuIndicator offset={activeIndex} />
    </ul>
  );
};

export default styled(MenuBar)`
  & {
    --indicator-color: ${(props) =>
      props.theme.isDarkMode ? palette.colorGray10 : palette.brand};

    display: flex;
    height: 100%;

    li {
      z-index: 1;
      transition: margin 0.5s;

      .icon {
        transition: color 0.5s;
      }

      &.active {
        margin-top: 12px;

        .icon {
          color: var(--indicator-color);
        }
      }
    }
  }
`;

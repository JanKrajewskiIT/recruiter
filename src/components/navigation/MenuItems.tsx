import MenuItem from "@/components/navigation/MenuItem";
import { type NavItem, navItems } from "@/components/navigation/NavItem";
import { palette } from "@/components/theme/theme";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";
import { useCallback } from "react";

interface IMenuItemsProps {
  active: NavItem;
  setActive: (active: NavItem) => void;
}

const MenuItems = ({
  className,
  active,
  setActive,
}: Props<IMenuItemsProps>) => {
  const handleActiveChange = useCallback(
    (active: NavItem) => () => {
      setActive(active);
    },
    [setActive],
  );

  return (
    <ul className={className}>
      {navItems.map(({ name, href, icon }) => (
        <MenuItem
          key={name}
          className={active?.name === name ? "active" : ""}
          href={href}
          icon={icon}
          onClick={handleActiveChange({ name, href, icon })}
        />
      ))}
      <div className="indicator">
        <span></span>
      </div>
    </ul>
  );
};

export default styled(MenuItems)`
  & {
    --background-color: ${(props) => props.theme.palette.background.default};
    --indicator-color: ${(props) =>
      props.theme.isDarkMode ? "#b8bcc5" : palette.brand};

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
          opacity: 1;
        }
      }
    }

    .indicator {
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
      transition: transform 0.5s;
    }

    .indicator::before,
    .indicator::after {
      content: "";
      position: absolute;
      top: 35px;
      width: 20px;
      height: 20px;
    }

    .indicator::before {
      left: -19.2px;
      border-bottom-right-radius: 20px;
      box-shadow: 6px 8px 4px 2px var(--background-color);
    }

    .indicator::after {
      right: -19.2px;
      border-bottom-left-radius: 20px;
      box-shadow: -6px 8px 4px 2px var(--background-color);
    }

    .indicator span {
      width: 44px;
      height: 44px;
      border: 2.5px solid var(--indicator-color);
      background: var(--background-color);
      border-radius: 50%;
      transform-origin: bottom;
    }

    li:nth-child(2).active ~ .indicator {
      transform: translateX(calc(var(--header-height) * 1));
    }

    li:nth-child(3).active ~ .indicator {
      transform: translateX(calc(var(--header-height) * 2));
    }

    li:nth-child(4).active ~ .indicator {
      transform: translateX(calc(var(--header-height) * 3));
    }

    li:nth-child(5).active ~ .indicator {
      transform: translateX(calc(var(--header-height) * 4));
    }
  }
`;

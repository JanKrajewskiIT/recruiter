import { type NavItem, navItems } from "@/components/navigation/NavItem";
import { palette } from "@/components/theme/theme";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";
import { useRouter } from "next/navigation";
import { useCallback } from "react";

interface INavItemsProps {
  active: NavItem;
  setActive: (active: NavItem) => void;
}

const NavItems = ({ className, active, setActive }: Props<INavItemsProps>) => {
  const router = useRouter();

  const handleActiveChange = useCallback(
    (active: NavItem) => () => {
      setActive(active);
      router.push(active.href);
    },
    [router, setActive],
  );

  return (
    <ul className={className}>
      {navItems.map(({ name, href, icon: Icon }) => (
        <li
          key={name}
          className={active?.name === name ? "active" : ""}
          onClick={handleActiveChange({ name, href, icon: Icon })}
        >
          <Icon className="icon" />
        </li>
      ))}
      <div className="indicator">
        <span></span>
      </div>
    </ul>
  );
};

export default styled(NavItems)`
  & {
    --background-color: ${(props) => props.theme.palette.background.default};
    --indicator-color: ${(props) =>
      props.theme.isDarkMode ? "#b8bcc5" : palette.brand};

    display: flex;
    height: 100%;

    li {
      display: flex;
      justify-content: center;
      align-items: center;
      list-style: none;
      width: var(--header-height);
      cursor: pointer;
      z-index: 1;
      transition: margin 0.5s;

      .icon {
        font-size: 1.5em;
        color: var(--background-color);
        opacity: 0.75;
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

import { type NavItem, navItems } from "@/components/navigation/NavItem";
import { type Props } from "@/models/props";
import styled from "@emotion/styled";
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
          className={`list ${active?.name === name ? "active" : ""}`}
          onClick={handleActiveChange({ name, href, icon: Icon })}
        >
          <a>
            <span className="icon">
              <Icon />
            </span>
          </a>
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
    display: flex;
    width: 350px;

    li {
      position: relative;
      list-style: none;
      width: var(--header-height);
      height: var(--header-height);
      z-index: 1;
    }

    li a {
      position: relative;
      display: flex;
      justify-content: center;
      align-items: center;
      flex-direction: column;
      width: 100%;
      text-align: center;
      font-weight: 500;
    }

    li a .icon {
      position: relative;
      display: block;
      line-height: 65px;
      font-size: 1.5em;
      text-align: center;
      transition: 0.5s;
      color: var(--body-background);
      opacity: 0.75;
    }

    li.active a .icon {
      transform: translateY(7px);
      opacity: 1;
      color: var(--nav-background);
    }

    .indicator {
      top: 6px;
      position: absolute;
      width: var(--header-height);
      height: var(--header-height);
      border-top-left-radius: 35px;
      border-top-right-radius: 35px;
      border: 6px solid var(--color-gray-10);
      background: var(--color-gray-10);
      cursor: pointer;
      transition: 0.5s;
    }

    .indicator::before {
      content: "";
      position: absolute;
      top: 29px;
      left: -24.75px;
      width: 20px;
      height: 20px;
      border-bottom-right-radius: 20px;
      box-shadow: 5px 8px 4px 2px var(--color-gray-10);
      z-index: -1;
    }

    .indicator::after {
      content: "";
      position: absolute;
      top: 29px;
      right: -24.75px;
      width: 20px;
      height: 20px;
      border-bottom-left-radius: 20px;
      box-shadow: -5px 8px 4px 2px var(--color-gray-10);
      z-index: -1;
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

    .indicator span {
      position: absolute;
      bottom: 2px;
      left: 2px;
      width: 44px;
      height: 44px;
      border: 2.5px solid var(--nav-background);
      background: var(--body-background);
      border-radius: 50%;
      transform-origin: bottom;
    }
  }
`;

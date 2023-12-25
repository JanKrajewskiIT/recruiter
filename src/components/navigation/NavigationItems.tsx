"use client";

import { type NavigationItem, elements } from "@/components/navigation/items";
import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";
import { useCallback, useState } from "react";

interface INavigationItemsProps {
  onItemChange: (header: string) => void;
}

const NavigationItems = ({
  className,
  onItemChange,
}: PropsWithClassName<INavigationItemsProps>) => {
  const [active, setActive] = useState<NavigationItem>(elements?.[0]);

  const handleActiveChange = useCallback(
    (active: NavigationItem) => () => {
      setActive(active);
      onItemChange(active.name);
    },
    [onItemChange],
  );

  return (
    <ul className={className}>
      {elements.map(({ name, icon: Icon }) => (
        <li
          key={name}
          className={`list ${active?.name === name ? "active" : ""}`}
          onClick={handleActiveChange({ name, icon: Icon })}
        >
          <a href="#">
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

export default styled(NavigationItems)`
  & {
    display: flex;
    width: 350px;

    li {
      position: relative;
      list-style: none;
      width: 70px;
      height: 70px;
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
      line-height: 75px;
      font-size: 1.5em;
      text-align: center;
      transition: 0.5s;
      color: var(--body-background);
      opacity: 0.75;
    }

    li.active a .icon {
      transform: translateY(-6px);
      opacity: 1;
      color: var(--nav-background);
    }

    .indicator {
      position: absolute;
      top: -10px;
      width: 72px;
      height: 72px;
      border-bottom-left-radius: 35px;
      border-bottom-right-radius: 35px;
      border: 6px solid var(--body-background);
      background: var(--body-background);
      cursor: pointer;
      transition: 0.5s;
    }

    .indicator::before {
      content: "";
      position: absolute;
      top: 4px;
      left: -24.75px;
      width: 20px;
      height: 20px;
      border-top-right-radius: 20px;
      box-shadow: 4px -6px 0 2px var(--body-background);
    }

    .indicator::after {
      content: "";
      position: absolute;
      top: 4px;
      right: -24.75px;
      width: 20px;
      height: 20px;
      border-top-left-radius: 20px;
      box-shadow: -4px -6px 0 2px var(--body-background);
      z-index: -1;
    }

    li:nth-child(2).active ~ .indicator {
      transform: translateX(calc(70px * 1));
    }

    li:nth-child(3).active ~ .indicator {
      transform: translateX(calc(70px * 2));
    }

    li:nth-child(4).active ~ .indicator {
      transform: translateX(calc(70px * 3));
    }

    li:nth-child(5).active ~ .indicator {
      transform: translateX(calc(70px * 4));
    }

    .indicator span {
      position: absolute;
      bottom: 2px;
      left: 4px;
      width: 52px;
      height: 52px;
      border: 3.5px solid var(--nav-background);
      background: var(--body-background);
      border-radius: 50%;
      transform-origin: bottom;
    }
  }
`;

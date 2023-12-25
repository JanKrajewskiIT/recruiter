"use client";

import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";
import { BiLogoReact } from "react-icons/bi";
import NavigationItems from "@/components/navigation/NavigationItems";
import UserMenu from "@/components/navigation/UserMenu";
import { useState } from "react";
import { Typography } from "@mui/material";
import { type NavigationItem, elements } from "@/components/navigation/items";
import { usePathname } from "next/navigation";

const Navigation = ({ className }: PropsWithClassName) => {
  const pathname = usePathname();
  const [active, setActive] = useState<NavigationItem>(
    elements.find((e) => e.href === pathname) ?? elements[0],
  );

  return (
    <div className={className}>
      <BiLogoReact className="logo-icon" />
      <Typography className="item-name">{active.name}</Typography>
      <NavigationItems active={active} setActive={setActive} />
      <UserMenu className="user-menu" />
    </div>
  );
};

export default styled(Navigation)`
  & {
    display: grid;
    grid-template-columns: 60px 60px auto 120px;
    justify-items: center;
    column-gap: 15px;
    align-items: center;
    width: 100%;
    height: var(--header-height);
    padding: 0 10px;
    background: var(--nav-background);
    position: relative;
    z-index: 1;
    box-shadow: 0px 0px 2px var(--nav-background);
    color: var(--body-background);

    .logo-icon {
      justify-self: start;
      font-size: 60px;
      margin-top: 2px;
    }

    .item-name {
      justify-self: start;
    }

    .user-menu {
      justify-self: end;
      margin-right: 6px;
    }
  }
`;

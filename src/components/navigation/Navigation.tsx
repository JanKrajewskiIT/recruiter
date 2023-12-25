"use client";

import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";
import { BiLogoReact } from "react-icons/bi";
import NavigationItems from "@/components/navigation/NavigationItems";
import UserMenu from "@/components/navigation/UserMenu";
import { useCallback, useState } from "react";
import { Typography } from "@mui/material";
import { elements } from "@/components/navigation/items";

const Navigation = ({ className }: PropsWithClassName) => {
  const [header, setHeader] = useState(elements?.[0]?.name);

  const handleItemChange = useCallback((header: string) => {
    setHeader(header);
  }, []);

  return (
    <div className={className}>
      <BiLogoReact className="logo-icon" />
      <Typography className="item-name">{header}</Typography>
      <NavigationItems onItemChange={handleItemChange} />
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
    height: 70px;
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

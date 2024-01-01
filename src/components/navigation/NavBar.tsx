"use client";

import { type Props } from "@/models/props";
import NavigationItems from "@/components/navigation/NavItems";
import { useState } from "react";
import { AppBar, Typography, styled } from "@mui/material";
import { type NavItem, navItems } from "@/components/navigation/NavItem";
import { usePathname } from "next/navigation";
import ThemeSwitch from "@/components/navigation/ThemeSwitch";
import NavIcon from "@/components/navigation/NavLogo";
import { palette } from "@/components/theme/theme";

const NavBar = ({ className }: Props) => {
  const pathname = usePathname();
  const [active, setActive] = useState<NavItem>(
    navItems.find((e) => e.href === pathname) ?? navItems[0],
  );

  return (
    <AppBar className={className} position="static">
      <NavIcon />
      <Typography className="item-name">{active.name}</Typography>
      <NavigationItems active={active} setActive={setActive} />
      <ThemeSwitch />
    </AppBar>
  );
};

export default styled(NavBar)`
  & {
    display: grid;
    grid-template-columns: 45px 50px auto 80px;
    column-gap: 15px;
    justify-items: center;
    align-items: center;
    height: var(--header-height);
    padding: 0 10px;
    box-shadow: 0px 0px 4px
      ${(props) => (props.theme.isDarkMode ? "none" : palette.brand)};

    .item-name {
      justify-self: start;
    }
  }
`;

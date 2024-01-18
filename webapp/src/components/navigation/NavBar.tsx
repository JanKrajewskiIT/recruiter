"use client";

import { type Props } from "@/models/props";
import NavigationItems from "@/components/navigation/MenuBar";
import { useState } from "react";
import { AppBar, Typography, styled } from "@mui/material";
import { navItems } from "@/components/navigation/NavItem";
import { usePathname } from "next/navigation";
import ThemeSwitch from "@/components/navigation/ThemeSwitch";
import NavIcon from "@/components/navigation/NavLogo";
import { palette } from "@/components/theme/theme";
import AuthButton from "@/components/navigation/AuthButton";

const NavBar = ({ className }: Props) => {
  const pathname = usePathname();
  const [activeIndex, setActiveIndex] = useState<number>(
    navItems.findIndex((e) => e.href === pathname) ?? 0,
  );

  return (
    <AppBar className={className} position="static">
      <NavIcon className="logo-icon" />
      <Typography className="item-name">
        {navItems[activeIndex].name}
      </Typography>
      <NavigationItems
        activeIndex={activeIndex}
        setActiveIndex={setActiveIndex}
      />
      <ThemeSwitch className="theme-switch" />
      <AuthButton />
    </AppBar>
  );
};

export default styled(NavBar)`
  & {
    --shadow-color: ${(props) =>
      props.theme.isDarkMode ? "none" : palette.brand};

    display: grid;
    grid-template-columns: 45px 50px 1fr 45px 50px;
    column-gap: 15px;
    justify-items: center;
    align-items: center;
    height: var(--header-height);
    padding: 0 10px;
    box-shadow: 0px 0px 4px var(--shadow-color);

    .logo-icon,
    .item-name {
      justify-self: start;
    }

    .theme-switch {
      justify-self: end;
    }
  }
`;

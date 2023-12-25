import { type Props } from "@/models/props";
import styled from "@emotion/styled";
import { BiLogoReact } from "react-icons/bi";
import NavigationItems from "@/components/navigation/NavItems";
import UserMenu from "@/components/navigation/UserMenu";
import { useState } from "react";
import { Typography } from "@mui/material";
import { type NavItem, navItems } from "@/components/navigation/NavItem";
import { usePathname } from "next/navigation";
import ThemeSwitch from "@/components/navigation/ThemeSwitch";

interface INavBarProps {
  isDarkMode: boolean;
  setDarkMode: (isDarkMode: boolean) => void;
}

const NavBar = ({
  className,
  isDarkMode,
  setDarkMode,
}: Props<INavBarProps>) => {
  const pathname = usePathname();
  const [active, setActive] = useState<NavItem>(
    navItems.find((e) => e.href === pathname) ?? navItems[0],
  );

  return (
    <div className={className}>
      <BiLogoReact className="logo-icon" />
      <Typography className="item-name">{active.name}</Typography>
      <NavigationItems active={active} setActive={setActive} />
      <ThemeSwitch isDarkMode={isDarkMode} setDarkMode={setDarkMode} />
      <UserMenu className="user-menu" />
    </div>
  );
};

export default styled(NavBar)`
  & {
    display: grid;
    grid-template-columns: 60px 60px auto 40px 60px;
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

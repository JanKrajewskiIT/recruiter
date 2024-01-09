import { type IconType } from "react-icons";
import { FaHome, FaQuestion } from "react-icons/fa";
import { IoCalendar } from "react-icons/io5";
import { IoMdSettings } from "react-icons/io";
import { MdOutlineContentPasteSearch } from "react-icons/md";

export interface NavItem {
  name: string;
  href: string;
  icon: IconType;
}

export const navItems = [
  {
    name: "Home",
    href: "/",
    icon: FaHome,
  },
  {
    name: "Questions",
    href: "/questions",
    icon: FaQuestion,
  },
  {
    name: "Organizer",
    href: "/organizer",
    icon: IoCalendar,
  },
  {
    name: "Materials",
    href: "/materials",
    icon: MdOutlineContentPasteSearch,
  },
  {
    name: "Settings",
    href: "/settings",
    icon: IoMdSettings,
  },
] as NavItem[];

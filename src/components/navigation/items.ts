import { type IconType } from "react-icons";
import { FaThList, FaHome, FaQuestion } from "react-icons/fa";
import { IoCalendar } from "react-icons/io5";
import { IoMdSettings } from "react-icons/io";

export interface NavigationItem {
  name: string;
  icon: IconType;
}

export const elements = [
  {
    name: "Home",
    icon: FaHome,
  },
  {
    name: "Questions",
    icon: FaQuestion,
  },
  {
    name: "Organizer",
    icon: IoCalendar,
  },
  {
    name: "Materials",
    icon: FaThList,
  },
  {
    name: "Settings",
    icon: IoMdSettings,
  },
] as NavigationItem[];

import { type Props } from "@/models/props";
import { BiLogoReact } from "react-icons/bi";
import { styled } from "@mui/material";

const NavIcon = ({ className }: Props) => <BiLogoReact className={className} />;

export default styled(NavIcon)`
  & {
    justify-self: start;
    font-size: 50px;
    margin-top: 2px;
  }
`;

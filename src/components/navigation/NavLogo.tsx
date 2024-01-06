import { type Props } from "@/models/props";
import { BiLogoReact } from "react-icons/bi";
import { styled } from "@mui/material";

const NavLogo = ({ className }: Props) => <BiLogoReact className={className} />;

export default styled(NavLogo)`
  & {
    font-size: 50px;
    margin-top: 2px;
  }
`;

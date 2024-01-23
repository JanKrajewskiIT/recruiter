import Offers from "@/components/organizer/Offers";
import Statuses from "@/components/organizer/Statuses";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";

const Organizer = ({ className }: Props) => (
  <div className={className}>
    <Statuses />
    <Offers />
  </div>
);

export default styled(Organizer)`
  & {
    display: flex;
    flex-direction: column;
    height: 100%;
  }
`;

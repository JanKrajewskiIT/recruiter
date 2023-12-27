import Tile from "@/components/questions/Tile";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";

const array = [1, 2, 3, 4, 5, 6, 7, 8, 9];

const Tiles = ({ className }: Props) => (
  <div className={className}>
    {array.map((a) => (
      <Tile key={a} />
    ))}
  </div>
);

export default styled(Tiles)`
  & {
    display: grid;
    grid-gap: 10px;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
  }
`;

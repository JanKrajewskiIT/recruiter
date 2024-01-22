import Tile from "@/components/questions/Tile";
import { type Props } from "@/models/props";
import { questionsAtom } from "@/store/questions";
import { styled } from "@mui/material";
import { useAtom } from "jotai";

const Tiles = ({ className }: Props) => {
  const [{ data }] = useAtom(questionsAtom);

  return (
    <div className={className}>
      {data?.map((a) => <Tile key={a.id} title={a.name} />)}
    </div>
  );
};

export default styled(Tiles)`
  & {
    display: grid;
    grid-gap: 10px;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    overflow-y: auto;
    padding-right: 14px;
  }
`;

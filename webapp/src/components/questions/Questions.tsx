import Tiles from "@/components/questions/Tiles";
import { type Props } from "@/models/props";
import { categoriesAtom } from "@/store/theme";
import { Chip, styled } from "@mui/material";
import { useAtom } from "jotai";

const Questions = ({ className }: Props) => {
  const [{ data }] = useAtom(categoriesAtom);

  return (
    <div className={className}>
      {data?.map((a) => <Chip key={a.name} label={a.name} />)}
      <Tiles />
    </div>
  );
};

export default styled(Questions)`
  & {
  }
`;

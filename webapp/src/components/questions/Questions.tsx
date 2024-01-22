import Categories from "@/components/questions/Categories";
import Tiles from "@/components/questions/Tiles";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";

const Questions = ({ className }: Props) => {
  return (
    <div className={className}>
      <Categories />
      <Tiles />
    </div>
  );
};

export default styled(Questions)`
  & {
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    height: 100%;
  }
`;

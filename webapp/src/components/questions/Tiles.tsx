import Tile from "@/components/questions/Tile";
import { type Props } from "@/models/props";
import { questionsAtom } from "@/store/questions";
import { styled } from "@mui/material";
import { useAtom } from "jotai";

const defaultText =
  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Etiam tempor orci eu lobortis. Convallis posuere morbi leo urna. Nulla aliquet enim tortor at auctor urna nunc. Sed cras ornare arcu dui vivamus. Pellentesque habitant morbi tristique senectus et. Lorem sed risus ultricies tristique nulla aliquet enim. Neque ornare aenean euismod elementum nisi quis eleifend quam. Vel eros donec ac odio tempor orci. Venenatis a condimentum vitae sapien. In cursus turpis massa tincidunt dui. Etiam non quam lacus suspendisse faucibus interdum posuere. Ac auctor augue mauris augue neque gravida in fermentum et. Pellentesque sit amet porttitor eget dolor morbi non. Tellus molestie nunc non blandit massa enim nec dui. Auctor neque vitae tempus quam pellentesque nec nam aliquam. Diam maecenas ultricies mi eget mauris pharetra et. Leo in vitae turpis massa sed elementum.";

const Tiles = ({ className }: Props) => {
  const [{ data }] = useAtom(questionsAtom);

  return (
    <div className={className}>
      {data?.map((a) => (
        <Tile
          key={a.id}
          title={a.name}
          description={a.description ?? defaultText}
        />
      ))}
    </div>
  );
};

export default styled(Tiles)`
  & {
    display: grid;
    grid-gap: 20px;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    margin-bottom: auto;
  }
`;

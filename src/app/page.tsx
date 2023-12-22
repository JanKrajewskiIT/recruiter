import { styled } from "@mui/material";
import { PropsWithClassName } from "@/app/models/props";

const Home = ({ className }: PropsWithClassName) => (
  <main className={className}>
    <div></div>
  </main>
);

export default styled(Home)`
  & {
  }
`;

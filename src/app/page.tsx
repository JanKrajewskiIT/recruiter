"use client";

import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";

const array = [1, 2, 3, 4, 5, 6, 7, 8];

const Home = ({ className }: PropsWithClassName) => (
  <main className={className}>
    {array.map((a) => (
      <div key={a} className="tile"></div>
    ))}
  </main>
);

export default styled(Home)`
  & {
    display: grid;
    grid-gap: 15px;
    margin: 10px;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));

    .tile {
      border: 1px solid black;
      border-radius: 15px;
      height: 300px;
    }
  }
`;

"use client";

import { type Props } from "@/models/props";
import { Typography, styled } from "@mui/material";

const HomePage = ({ className }: Props) => (
  <div className={className}>
    <Typography>Home</Typography>
  </div>
);

export default styled(HomePage)`
  & {
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }
`;

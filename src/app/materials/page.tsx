"use client";

import { type Props } from "@/models/props";
import { Typography, styled } from "@mui/material";

const Materials = ({ className }: Props) => (
  <div className={className}>
    <Typography>Materials</Typography>
  </div>
);

export default styled(Materials)`
  & {
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }
`;

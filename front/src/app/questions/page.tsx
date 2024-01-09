"use client";

import { type Props } from "@/models/props";
import { Typography, styled } from "@mui/material";

const Questions = ({ className }: Props) => (
  <div className={className}>
    <Typography>Questions</Typography>
  </div>
);

export default styled(Questions)`
  & {
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }
`;

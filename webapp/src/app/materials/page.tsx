"use client";

import { type Props } from "@/models/props";
import { Typography, styled } from "@mui/material";

const MaterialsPage = ({ className }: Props) => (
  <div className={className}>
    <Typography>Materials</Typography>
  </div>
);

export default styled(MaterialsPage)`
  & {
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }
`;

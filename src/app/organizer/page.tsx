"use client";

import { type Props } from "@/models/props";
import { Typography, styled } from "@mui/material";

const Organizer = ({ className }: Props) => (
  <div className={className}>
    <Typography>Organizer</Typography>
  </div>
);

export default styled(Organizer)`
  & {
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }
`;

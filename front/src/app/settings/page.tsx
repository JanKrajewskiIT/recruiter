"use client";

import { type Props } from "@/models/props";
import { Typography, styled } from "@mui/material";

const Settings = ({ className }: Props) => (
  <div className={className}>
    <Typography>Settings</Typography>
  </div>
);

export default styled(Settings)`
  & {
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }
`;

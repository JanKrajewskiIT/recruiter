"use client";

import { type Props } from "@/models/props";
import styled from "@emotion/styled";
import { Typography } from "@mui/material";

const Settings = ({ className }: Props) => (
  <main className={className}>
    <Typography>Settings</Typography>
  </main>
);

export default styled(Settings)`
  & {
    display: flex;
    justify-content: center;
    align-items: center;
    height: calc(100vh - var(--header-height));
  }
`;

"use client";

import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";
import { Typography } from "@mui/material";

const Materials = ({ className }: PropsWithClassName) => (
  <main className={className}>
    <Typography>Materials</Typography>
  </main>
);

export default styled(Materials)`
  & {
    display: flex;
    justify-content: center;
    align-items: center;
    height: calc(100vh - var(--header-height));
  }
`;

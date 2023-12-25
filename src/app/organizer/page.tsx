"use client";

import { type PropsWithClassName } from "@/models/props";
import styled from "@emotion/styled";
import { Typography } from "@mui/material";

const Organizer = ({ className }: PropsWithClassName) => (
  <main className={className}>
    <Typography>Organizer</Typography>
  </main>
);

export default styled(Organizer)`
  & {
    display: flex;
    justify-content: center;
    align-items: center;
    height: calc(100vh - var(--header-height));
  }
`;

"use client";

import { type Props } from "@/models/props";
import styled from "@emotion/styled";
import { Typography } from "@mui/material";

const Questions = ({ className }: Props) => (
  <main className={className}>
    <Typography>Questions</Typography>
  </main>
);

export default styled(Questions)`
  & {
    display: flex;
    justify-content: center;
    align-items: center;
    height: calc(100vh - var(--header-height));
  }
`;

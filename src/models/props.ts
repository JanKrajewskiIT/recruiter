import { type PropsWithChildren } from "react";

export type Props<P = unknown> = PropsWithChildren<P> & {
  className?: string;
  disabled?: boolean;
  testTag?: string;
};

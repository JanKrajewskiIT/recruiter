import { type ReactNode } from "react";

export type PropsWithClassName<P = unknown> = P &
  IWithTestTag & {
    className?: string;
    disabled?: boolean;
  };

export type PropsWithChildren<P = unknown> = PropsWithClassName<P> & {
  children?: ReactNode;
};

export interface IWithTestTag {
  testTag?: string;
}

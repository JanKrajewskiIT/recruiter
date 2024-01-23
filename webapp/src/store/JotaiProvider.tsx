"use client";

import { Provider } from "jotai/react";
import { useHydrateAtoms } from "jotai/react/utils";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import { queryClientAtom } from "jotai-tanstack-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";
import { type PropsWithChildren } from "react";

const queryClient = new QueryClient({
  defaultOptions: {
    queries: {
      staleTime: Infinity,
    },
  },
});

const HydrateAtoms = ({ children }: PropsWithChildren) => {
  useHydrateAtoms([[queryClientAtom, queryClient]]);
  return children;
};

export const JotaiProvider = ({ children }: PropsWithChildren) => (
  <QueryClientProvider client={queryClient}>
    <Provider>
      <HydrateAtoms>{children}</HydrateAtoms>
    </Provider>
    <ReactQueryDevtools />
  </QueryClientProvider>
);

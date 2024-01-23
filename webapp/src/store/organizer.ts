import { atom } from "jotai";
import { atomWithQuery } from "jotai-tanstack-query";

export interface Offer {
  name: string;
  companyName: string;
  link: string;
  description: string | null;
}

export const selectedStatus = atom<string | null>(null);

export const offerStatusesAtom = atomWithQuery<string[]>(() => ({
  queryKey: ["offerStatuses"],
  queryFn: async () => {
    const result = await fetch(
      `${process.env.NEXT_PUBLIC_API_URL}/offers/statuses`,
    );
    return await result.json();
  },
}));

export const ordersAtom = atomWithQuery<Offer[]>((get) => ({
  queryKey: ["offers", get(selectedStatus)],
  queryFn: async ({ queryKey: [, section] }) => {
    if (section) {
      const result = await fetch(
        `${process.env.NEXT_PUBLIC_API_URL}/offers?status=${section as string}`,
      );

      return await result.json();
    }

    return [];
  },
}));

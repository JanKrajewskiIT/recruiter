import { atomWithQuery } from "jotai-tanstack-query";

export const defaultOfferStatus = "New";

export const statusesAtom = atomWithQuery<string[]>(() => ({
  queryKey: ["statuses"],
  queryFn: async () => {
    const result = await fetch(
      `${process.env.NEXT_PUBLIC_API_URL}/dictionaries/statuses`,
    );
    return await result.json();
  },
}));

export const positionsAtom = atomWithQuery<string[]>(() => ({
  queryKey: ["positions"],
  queryFn: async () => {
    const result = await fetch(
      `${process.env.NEXT_PUBLIC_API_URL}/dictionaries/positions`,
    );
    return await result.json();
  },
}));

export const citiesAtom = atomWithQuery<string[]>(() => ({
  queryKey: ["cities"],
  queryFn: async () => {
    const result = await fetch(
      `${process.env.NEXT_PUBLIC_API_URL}/dictionaries/cities`,
    );
    return await result.json();
  },
}));

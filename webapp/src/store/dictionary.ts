import { atomWithQuery } from "jotai-tanstack-query";

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

export const reasonsAtom = atomWithQuery<string[]>(() => ({
  queryKey: ["reasons"],
  queryFn: async () => {
    const result = await fetch(
      `${process.env.NEXT_PUBLIC_API_URL}/dictionaries/reasons`,
    );
    return await result.json();
  },
}));

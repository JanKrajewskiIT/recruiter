import type Category from "@/models/Category";
import { atom } from "jotai";
import { atomWithQuery } from "jotai-tanstack-query";

export const selectedCategoryId = atom<string | null>(null);

export const categoriesAtom = atomWithQuery<Category[]>(() => ({
  queryKey: ["categories"],
  queryFn: async () => {
    const result = await fetch(`${process.env.NEXT_PUBLIC_API_URL}/categories`);
    return await result.json();
  },
}));

export const questionsAtom = atomWithQuery<Category[]>((get) => ({
  queryKey: ["questions", get(selectedCategoryId)],
  queryFn: async ({ queryKey: [, id] }) => {
    if (id) {
      const result = await fetch(
        `${process.env.NEXT_PUBLIC_API_URL}/questions?categoryId=${id as string}`,
      );

      return await result.json();
    }

    return [];
  },
}));

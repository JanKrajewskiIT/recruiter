import { atomWithQuery } from "jotai-tanstack-query";

export interface Category {
  name: string;
  description: string | null;
  iconName: string | null;
}

export const categoriesAtom = atomWithQuery<Category[]>(() => ({
  queryKey: ["categories"],
  queryFn: async () => {
    const res = await fetch(`http://localhost:9005/categories`);
    return await res.json();
  },
}));

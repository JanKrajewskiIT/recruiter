import { atom } from "jotai";
import { atomWithQuery } from "jotai-tanstack-query";
import { useMutation, useQueryClient } from "@tanstack/react-query";

export interface Offer {
  id: string;
  name: string;
  link: string;
  company: string;
  city: string;
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

export const offersAtom = atomWithQuery<Offer[]>((get) => ({
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

export const useAddOfferMutation = () => {
  const queryClient = useQueryClient();

  return useMutation({
    mutationKey: ["addOffer"],
    mutationFn: async (offer: Offer) => {
      const result = await fetch(`${process.env.NEXT_PUBLIC_API_URL}/offers`, {
        method: "POST",
        headers: { "Content-type": "application/json; charset=UTF-8" },
        body: JSON.stringify(offer),
      });

      await queryClient.invalidateQueries({ queryKey: ["offers"] });

      return await result.json();
    },
  });
};

export const useUpdateOfferMutation = () => {
  const queryClient = useQueryClient();

  return useMutation({
    mutationKey: ["updateOffer"],
    mutationFn: async (offer: Offer) => {
      const result = await fetch(`${process.env.NEXT_PUBLIC_API_URL}/offers`, {
        method: "PUT",
        headers: { "Content-type": "application/json; charset=UTF-8" },
        body: JSON.stringify(offer),
      });

      await queryClient.invalidateQueries({ queryKey: ["offers"] });

      return await result.json();
    },
  });
};

export const useUpdateOfferStatusMutation = () => {
  const queryClient = useQueryClient();

  return useMutation({
    mutationKey: ["updateOfferStatus"],
    mutationFn: async ({ id, status }: { id: string; status: string }) => {
      const result = await fetch(
        `${process.env.NEXT_PUBLIC_API_URL}/offers/${id}?status=${status}`,
        {
          method: "PATCH",
        },
      );

      await queryClient.invalidateQueries({ queryKey: ["offers"] });

      return await result.json();
    },
  });
};

export const useDeleteOfferMutation = () => {
  const queryClient = useQueryClient();

  return useMutation({
    mutationKey: ["deleteOffer"],
    mutationFn: async (id: string) => {
      const result = await fetch(
        `${process.env.NEXT_PUBLIC_API_URL}/offers/${id}`,
        {
          method: "DELETE",
        },
      );

      await queryClient.invalidateQueries({ queryKey: ["offers"] });

      return await result.json();
    },
  });
};

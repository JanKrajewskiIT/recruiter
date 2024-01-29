import { atom } from "jotai";
import { atomWithQuery } from "jotai-tanstack-query";
import { useMutation, useQueryClient } from "@tanstack/react-query";
import { selectAtom, splitAtom } from "jotai/utils";
import type Offer from "@/models/Offer";
import type OfferStatus from "@/models/OfferStatus";
import type OfferState from "@/models/OfferState";

export const selectedStatusAtom = atom<OfferStatus | null>(null);

const offersAtom = atomWithQuery<Offer[]>((get) => ({
  queryKey: ["offers", get(selectedStatusAtom)],
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

const selectedOffersAtom = selectAtom(offersAtom, (x) => x.data ?? []);
export const splitOffersAtom = splitAtom(selectedOffersAtom, (x) => x.id);
export const offersLengthAtom = selectAtom(
  offersAtom,
  (x) => x.data?.length ?? 0,
);

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
      const result = await fetch(
        `${process.env.NEXT_PUBLIC_API_URL}/offers/${offer.id}`,
        {
          method: "PUT",
          headers: { "Content-type": "application/json; charset=UTF-8" },
          body: JSON.stringify(offer),
        },
      );

      await queryClient.invalidateQueries({ queryKey: ["offers"] });

      return await result.json();
    },
  });
};

export const useUpdateOfferStateMutation = () => {
  const queryClient = useQueryClient();

  return useMutation({
    mutationKey: ["updateOfferState"],
    mutationFn: async (state: OfferState) => {
      const result = await fetch(
        `${process.env.NEXT_PUBLIC_API_URL}/offers/${state.id}`,
        {
          method: "PATCH",
          headers: { "Content-type": "application/json; charset=UTF-8" },
          body: JSON.stringify(state),
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

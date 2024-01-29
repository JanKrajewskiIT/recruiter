import type OfferStatus from "@/models/OfferStatus";

export default interface OfferState {
  id: string;
  status: OfferStatus;
  reasons: string[];
}

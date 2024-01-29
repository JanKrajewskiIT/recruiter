enum OfferStatus {
  New = "New",
  Considered = "Considered",
  Sent = "Sent",
  Rejected = "Rejected",
}

export const OfferStatusTranslation: Record<string, string> = {
  [OfferStatus.New]: "Nowe",
  [OfferStatus.Considered]: "Rozważane",
  [OfferStatus.Sent]: "Wysłane",
  [OfferStatus.Rejected]: "Odrzucone",
};

export default OfferStatus;

import { type Props } from "@/models/props";
import { IconButton } from "@mui/material";
import { useCallback } from "react";
import { RxExternalLink } from "react-icons/rx";

interface IRedirectToOfferProps {
  link: string;
}

const RedirectToOffer = ({ className, link }: Props<IRedirectToOfferProps>) => {
  const handleRedirect = useCallback(() => window.open(link), [link]);

  return (
    <IconButton className={className} edge="end" onClick={handleRedirect}>
      <RxExternalLink />
    </IconButton>
  );
};

export default RedirectToOffer;

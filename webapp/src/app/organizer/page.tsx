"use client";

import Organizer from "@/components/organizer/Organizer";
import { type Props } from "@/models/props";
import { OidcSecure } from "@axa-fr/react-oidc";

const OrganizerPage = ({ className }: Props) => (
  <OidcSecure>
    <Organizer className={className} />
  </OidcSecure>
);

export default OrganizerPage;

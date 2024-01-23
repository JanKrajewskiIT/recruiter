"use client";

import Profile from "@/components/settings/Profile";
import { type Props } from "@/models/props";
import { OidcSecure } from "@axa-fr/react-oidc";

const SettingsPage = ({ className }: Props) => (
  <OidcSecure>
    <Profile className={className} />
  </OidcSecure>
);

export default SettingsPage;

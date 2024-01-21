"use client";

import {
  type OidcConfiguration,
  OidcProvider,
  TokenRenewMode,
} from "@axa-fr/react-oidc";
import { type PropsWithChildren } from "react";

export const keycloakConfiguration: OidcConfiguration = {
  client_id: `${process.env.NEXT_PUBLIC_AUTH_CLIENT_ID}`,
  redirect_uri: `${process.env.NEXT_PUBLIC_AUTH_URL}/settings`,
  scope: `${process.env.NEXT_PUBLIC_AUTH_SCOPE}`,
  authority: `${process.env.NEXT_PUBLIC_AUTH_ISSUER}`,
  refresh_time_before_tokens_expiration_in_second: 40,
  service_worker_relative_url: "/OidcServiceWorker.js",
  service_worker_only: true,
  token_renew_mode: TokenRenewMode.access_token_invalid,
  token_request_extras: {
    client_secret: `${process.env.NEXT_PUBLIC_AUTH_CLIENT_SECRET}`,
  },
};

const NextAuthProvider = ({ children }: PropsWithChildren) => (
  <OidcProvider configuration={keycloakConfiguration}>{children}</OidcProvider>
);

export default NextAuthProvider;

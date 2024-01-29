import { type Props } from "@/models/props";
import { useOidcAccessToken } from "@axa-fr/react-oidc";
import { Divider, Typography } from "@mui/material";
import React from "react";

const AccessTokenInfo = ({ className }: Props) => {
  const { accessToken, accessTokenPayload } = useOidcAccessToken();

  if (!accessToken) {
    return (
      <Typography variant="subtitle2">You are not authenticated</Typography>
    );
  }

  return (
    <div className={className}>
      <Typography variant="subtitle1" color="error.main">
        Please consider to configure the ServiceWorker in order to protect your
        application from XSRF attacks. &quot;access_token&quot; and
        &quot;refresh_token&quot; will never be accessible from your client side
        javascript.
      </Typography>

      <Divider />

      <Typography variant="subtitle2">Access Token</Typography>
      <Typography variant="caption" color="text.secondary">
        {JSON.stringify(accessToken)}
      </Typography>

      <Divider />

      <Typography variant="subtitle2">Access Token Payload</Typography>
      <Typography variant="caption" color="text.secondary">
        {JSON.stringify(accessTokenPayload)}
      </Typography>
    </div>
  );
};

export default AccessTokenInfo;

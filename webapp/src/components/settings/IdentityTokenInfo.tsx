import { type Props } from "@/models/props";
import { useOidcIdToken } from "@axa-fr/react-oidc";
import { Divider, Typography } from "@mui/material";
import React from "react";

const IdentityTokenInfo = ({ className }: Props) => {
  const { idToken, idTokenPayload } = useOidcIdToken();

  if (!idToken) {
    return (
      <Typography variant="subtitle2">You are not authenticated</Typography>
    );
  }

  return (
    <div className={className}>
      <Typography variant="subtitle2">Id Token</Typography>
      <Typography variant="caption" color="text.secondary">
        {JSON.stringify(idToken)}
      </Typography>

      <Divider />

      {idTokenPayload != null && (
        <>
          <Typography variant="subtitle2">Id Token Payload</Typography>
          <Typography variant="caption" color="text.secondary">
            {JSON.stringify(idTokenPayload)}
          </Typography>
        </>
      )}
    </div>
  );
};

export default IdentityTokenInfo;

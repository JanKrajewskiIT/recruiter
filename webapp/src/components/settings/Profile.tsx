import { type Props } from "@/models/props";
import {
  type OidcUserInfo,
  OidcUserStatus,
  useOidcAccessToken,
  useOidcIdToken,
  useOidcUser,
} from "@axa-fr/react-oidc";
import { Button, Divider, Typography } from "@mui/material";
import React from "react";
import { IoMdRefresh } from "react-icons/io";

interface OidcUserRoleInfo extends OidcUserInfo {
  role?: string[];
}

const DisplayUserInfo = ({ className }: Props) => {
  const { oidcUser, oidcUserLoadingState, reloadOidcUser } =
    useOidcUser<OidcUserRoleInfo>();

  switch (oidcUserLoadingState) {
    case OidcUserStatus.Loading:
      return (
        <Typography className={className} variant="subtitle2">
          User Information are loading
        </Typography>
      );
    case OidcUserStatus.Unauthenticated:
      return (
        <Typography className={className} variant="subtitle2">
          You are not authenticated
        </Typography>
      );
    case OidcUserStatus.LoadingError:
      return (
        <Typography className={className} variant="subtitle2">
          Failed to load user information
        </Typography>
      );
    default:
      return (
        <div className={className}>
          <Typography variant="subtitle2">User information</Typography>
          <Typography variant="caption" color="text.secondary">
            {JSON.stringify(oidcUser)}
          </Typography>

          <Button
            variant="outlined"
            startIcon={<IoMdRefresh />}
            onClick={reloadOidcUser}
          >
            Reload user
          </Button>
        </div>
      );
  }
};

const DisplayAccessToken = ({ className }: Props) => {
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

const DisplayIdToken = ({ className }: Props) => {
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

const Profile = ({ className }: Props) => (
  <div className={className}>
    <DisplayAccessToken />
    <Divider />
    <DisplayIdToken />
    <Divider />
    <DisplayUserInfo />
  </div>
);

export default Profile;

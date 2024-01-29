import { type Props } from "@/models/props";
import {
  type OidcUserInfo,
  OidcUserStatus,
  useOidcUser,
} from "@axa-fr/react-oidc";
import { Button, Typography } from "@mui/material";
import React from "react";
import { IoMdRefresh } from "react-icons/io";

interface OidcUserRoleInfo extends OidcUserInfo {
  role?: string[];
}

const UserInfo = ({ className }: Props) => {
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

export default UserInfo;

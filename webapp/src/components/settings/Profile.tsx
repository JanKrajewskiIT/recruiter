import AccessTokenInfo from "@/components/settings/AccessTokenInfo";
import IdentityTokenInfo from "@/components/settings/IdentityTokenInfo";
import UserInfo from "@/components/settings/UserInfo";
import { type Props } from "@/models/props";
import { Divider } from "@mui/material";
import React from "react";

const Profile = ({ className }: Props) => (
  <div className={className}>
    <AccessTokenInfo />
    <Divider />
    <IdentityTokenInfo />
    <Divider />
    <UserInfo />
  </div>
);

export default Profile;

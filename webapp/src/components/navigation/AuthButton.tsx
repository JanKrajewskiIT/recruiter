import { type Props } from "@/models/props";
import { useOidc } from "@axa-fr/react-oidc";
import { styled } from "@mui/material";
import { useCallback } from "react";
import { AiOutlineLogin, AiOutlineLogout } from "react-icons/ai";

const AuthButton = ({ className }: Props) => {
  const { login, logout, isAuthenticated } = useOidc();

  const handleLogin = useCallback(async () => await login(), [login]);
  const handleLogout = useCallback(async () => await logout(), [logout]);

  return (
    <div className={className}>
      {isAuthenticated ? (
        <AiOutlineLogout onClick={handleLogout} />
      ) : (
        <AiOutlineLogin onClick={handleLogin} />
      )}
    </div>
  );
};

export default styled(AuthButton)`
  & {
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;

    svg {
      font-size: 2em;
      color: var(--color-gray-10);
    }
  }
`;

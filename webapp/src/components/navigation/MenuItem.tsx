import { type NavItem } from "@/components/navigation/NavItem";
import { type Props } from "@/models/props";
import { styled } from "@mui/material";
import { useRouter } from "next/navigation";
import { useCallback } from "react";

interface IMenuItemProps extends Pick<NavItem, "href" | "icon"> {
  onClick: () => void;
}

const MenuItem = ({
  className,
  children,
  href,
  icon: Icon,
  onClick,
}: Props<IMenuItemProps>) => {
  const router = useRouter();

  const handleChange = useCallback(() => {
    onClick();
    router.push(href);
  }, [href, onClick, router]);

  return (
    <li className={className} onClick={handleChange}>
      <Icon className="icon" />
      {children}
    </li>
  );
};

export default styled(MenuItem)`
  & {
    display: flex;
    justify-content: center;
    align-items: center;
    list-style: none;
    width: var(--header-height);
    cursor: pointer;

    .icon {
      font-size: 1.5em;
      color: var(--color-gray-10);
    }
  }
`;

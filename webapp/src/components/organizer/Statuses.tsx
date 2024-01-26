import { type Props } from "@/models/props";
import { statusesAtom } from "@/store/dictionary";
import { selectedStatusAtom } from "@/store/organizer";
import { Chip, styled } from "@mui/material";
import { useAtom } from "jotai";
import { useCallback } from "react";

const Statuses = ({ className }: Props) => {
  const [{ data }] = useAtom(statusesAtom);
  const [status, setStatus] = useAtom(selectedStatusAtom);

  const handleStatusChange = useCallback(
    (status: string) => () => setStatus(status),
    [setStatus],
  );

  return (
    <div className={className}>
      {data?.map((s) => (
        <Chip
          key={s}
          label={s}
          variant={status === s ? "filled" : "outlined"}
          onClick={handleStatusChange(s)}
        />
      ))}
    </div>
  );
};

export default styled(Statuses)`
  & {
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    margin-bottom: 20px;

    div {
      margin-right: 4px;
    }
  }
`;

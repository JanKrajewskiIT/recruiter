import OfferStatus, { OfferStatusTranslation } from "@/models/OfferStatus";
import { type Props } from "@/models/props";
import { selectedStatusAtom } from "@/store/organizer";
import { Chip, styled } from "@mui/material";
import { useAtom } from "jotai";
import { useCallback } from "react";

const Statuses = ({ className }: Props) => {
  const [status, setStatus] = useAtom(selectedStatusAtom);

  const handleStatusChange = useCallback(
    (status: OfferStatus) => () => setStatus(status),
    [setStatus],
  );

  return (
    <div className={className}>
      {Object.entries(OfferStatus).map(([, key]) => (
        <Chip
          key={key}
          label={OfferStatusTranslation[key]}
          variant={status === key ? "filled" : "outlined"}
          onClick={handleStatusChange(key)}
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

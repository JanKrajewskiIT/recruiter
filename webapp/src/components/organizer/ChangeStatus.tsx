import ChangeStateDialog from "@/components/organizer/ChangeStateDialog";
import type Offer from "@/models/Offer";
import OfferStatus, { OfferStatusTranslation } from "@/models/OfferStatus";
import { type Props } from "@/models/props";
import {
  selectedStatusAtom,
  useUpdateOfferStateMutation,
} from "@/store/organizer";
import {
  MenuItem,
  Select,
  Typography,
  type SelectChangeEvent,
  styled,
} from "@mui/material";
import { useAtom } from "jotai";
import { Fragment, useCallback, useState } from "react";

interface IChangeStatusProps {
  offer: Offer;
}

const ChangeStatus = ({ className, offer }: Props<IChangeStatusProps>) => {
  const [selectedStatus] = useAtom(selectedStatusAtom);
  const [status, setStatus] = useState<OfferStatus>(
    selectedStatus ?? OfferStatus.New,
  );
  const [open, setOpen] = useState(false);
  const { mutate } = useUpdateOfferStateMutation();

  const handleClose = useCallback(() => setOpen(false), []);
  const handleOpen = useCallback((event: SelectChangeEvent) => {
    setStatus(event.target.value as OfferStatus);
    setOpen(true);
  }, []);

  return (
    <Fragment>
      {selectedStatus && (
        <Select
          className={className}
          value={selectedStatus}
          size="small"
          onChange={handleOpen}
        >
          {Object.entries(OfferStatus).map(([value, key]) => (
            <MenuItem key={key} value={value}>
              <Typography variant="body2" color="text.secondary">
                {OfferStatusTranslation[key]}
              </Typography>
            </MenuItem>
          ))}
        </Select>
      )}
      <ChangeStateDialog
        open={open}
        offer={offer}
        status={status}
        onSubmit={mutate}
        onClose={handleClose}
      />
    </Fragment>
  );
};

export default styled(ChangeStatus)`
  & {
    > div {
      display: flex;
      flex-direction: column;
      justify-content: center;
      width: 90px;
    }
  }
`;

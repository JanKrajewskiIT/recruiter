import { type Props } from "@/models/props";
import { statusesAtom } from "@/store/dictionary";
import {
  selectedStatusAtom,
  useUpdateOfferStatusMutation,
} from "@/store/organizer";
import {
  MenuItem,
  Select,
  Typography,
  type SelectChangeEvent,
} from "@mui/material";
import { useAtom } from "jotai";
import { useCallback } from "react";

interface IChangeStatusProps {
  offerId: string;
}

const ChangeStatus = ({ className, offerId }: Props<IChangeStatusProps>) => {
  const [{ data }] = useAtom(statusesAtom);
  const [status] = useAtom(selectedStatusAtom);
  const { mutate } = useUpdateOfferStatusMutation();

  const handleStatusChange = useCallback(
    (event: SelectChangeEvent) =>
      mutate({ id: offerId, status: event.target.value }),
    [mutate, offerId],
  );

  return (
    status && (
      <Select
        className={className}
        value={status}
        label="Age"
        size="small"
        onChange={handleStatusChange}
      >
        {data?.map((s) => (
          <MenuItem key={s} value={s}>
            <Typography variant="body2" color="text.secondary">
              {s}
            </Typography>
          </MenuItem>
        ))}
      </Select>
    )
  );
};

export default ChangeStatus;

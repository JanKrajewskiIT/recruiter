import { type Props } from "@/models/props";
import {
  offerStatusesAtom,
  selectedStatus,
  useUpdateOfferStatusMutation,
} from "@/store/organizer";
import { MenuItem, Select, type SelectChangeEvent } from "@mui/material";
import { useAtom } from "jotai";
import { useCallback } from "react";

interface IChangeStatusProps {
  offerId: string;
}

const ChangeStatus = ({ className, offerId }: Props<IChangeStatusProps>) => {
  const [{ data }] = useAtom(offerStatusesAtom);
  const [status] = useAtom(selectedStatus);
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
            {s}
          </MenuItem>
        ))}
      </Select>
    )
  );
};

export default ChangeStatus;

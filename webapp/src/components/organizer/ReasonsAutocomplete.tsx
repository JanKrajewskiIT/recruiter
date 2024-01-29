import MultipleAutocomplete from "@/components/common/MultipleAutocomplete";
import { type Props } from "@/models/props";
import { reasonsAtom } from "@/store/dictionary";
import { useAtom } from "jotai";

interface IReasonsAutocompleteProps {
  reasons: string[];
  onReasonsChange: (value: string[]) => void;
}

const ReasonsAutocomplete = ({
  className,
  reasons,
  onReasonsChange,
}: Props<IReasonsAutocompleteProps>) => {
  const [{ data }] = useAtom(reasonsAtom);

  return (
    <MultipleAutocomplete
      className={className}
      name="reasons"
      label="Lista powodów"
      options={data ?? []}
      value={reasons}
      onValueChange={onReasonsChange}
    />
  );
};

export default ReasonsAutocomplete;

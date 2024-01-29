import FormDialog from "@/components/common/FormDialog";
import InputText from "@/components/common/InputText";
import SingleAutocomplete from "@/components/common/SingleAutocomplete";
import type Offer from "@/models/Offer";
import { type Props } from "@/models/props";
import { citiesAtom, positionsAtom } from "@/store/dictionary";
import { useAtom } from "jotai";

interface IDefineOfferDialogProps {
  open: boolean;
  offer?: Offer;
  title: string;
  submitTitle: string;
  onClose: () => void;
  onSubmit: (offer: Offer) => void;
}

const DefineOfferDialog = ({
  className,
  open,
  offer,
  title,
  submitTitle,
  onClose,
  onSubmit,
}: Props<IDefineOfferDialogProps>) => {
  const [{ data: positions }] = useAtom(positionsAtom);
  const [{ data: cities }] = useAtom(citiesAtom);

  return (
    <FormDialog
      className={className}
      open={open}
      title={title}
      description={`
        Wymagane jest podanie wszystkich informacji tj. tytułu stanowiska,
        linku do oferty, nazwy firmy rekrutującej a także miasta, którego ta oferta dotyczy. 
        W przypadku oferty zdalnej można zamiast miasta wpisać 'Remote'.`}
      submitTitle={submitTitle}
      onClose={onClose}
      onSubmit={onSubmit}
    >
      <SingleAutocomplete
        name="name"
        label="Tytuł stanowiska"
        defaultValue={offer?.name}
        options={positions ?? []}
      />
      <InputText
        name="link"
        label="Link do szczegółów oferty"
        type="url"
        defaultValue={offer?.link}
      />
      <InputText
        name="company"
        label="Nazwa firmy"
        defaultValue={offer?.company}
      />
      <SingleAutocomplete
        name="city"
        label="Miasto"
        defaultValue={offer?.city}
        options={cities ?? []}
      />
    </FormDialog>
  );
};

export default DefineOfferDialog;

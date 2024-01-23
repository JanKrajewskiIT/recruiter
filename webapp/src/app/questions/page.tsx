"use client";

import Questions from "@/components/questions/Questions";
import { type Props } from "@/models/props";
import { OidcSecure } from "@axa-fr/react-oidc";

const QuestionsPage = ({ className }: Props) => (
  <OidcSecure>
    <Questions className={className} />
  </OidcSecure>
);

export default QuestionsPage;

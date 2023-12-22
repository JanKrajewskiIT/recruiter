import { Html, Head, Main, NextScript, DocumentProps } from "next/document";
import {
  DocumentHeadTags,
  documentGetInitialProps,
  DocumentHeadTagsProps,
} from "@mui/material-nextjs/v14-pagesRouter";

const MyDocument = (props: DocumentProps & DocumentHeadTagsProps) => (
  <Html lang="en">
    <Head>
      <DocumentHeadTags {...props} />
    </Head>
    <body>
      <Main />
      <NextScript />
    </body>
  </Html>
);

MyDocument.getInitialProps = documentGetInitialProps;

export default MyDocument;

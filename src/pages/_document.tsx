import {
  Html,
  Head,
  Main,
  NextScript,
  type DocumentProps,
} from "next/document";
import {
  DocumentHeadTags,
  documentGetInitialProps,
  type DocumentHeadTagsProps,
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

import type { AppProps } from "next/app";
import { AppCacheProvider } from "@mui/material-nextjs/v14-pagesRouter";

const MyApp = ({ Component, pageProps }: AppProps) => (
  <AppCacheProvider>
    <Component {...pageProps} />
  </AppCacheProvider>
);

export default MyApp;

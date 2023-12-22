import type { AppProps } from "next/app";
import { AppCacheProvider } from "@mui/material-nextjs/v14-pagesRouter";

export default function MyApp({ Component, pageProps }: AppProps) {
  return (
    <AppCacheProvider>
      <Component {...pageProps} />
    </AppCacheProvider>
  );
}

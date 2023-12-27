"use client";
import { type PropsWithChildren, useState } from "react";
import createCache, { type Options } from "@emotion/cache";
import { useServerInsertedHTML } from "next/navigation";
import { CacheProvider } from "@emotion/react";
import { ThemeProvider } from "@mui/material/styles";
import CssBaseline from "@mui/material/CssBaseline";
import { isDarkModeAtom } from "@/store/theme";
import { useAtom } from "jotai";
import { darkTheme, lightTheme } from "@/styles/theme";

const ThemeRegistry = ({
  options,
  children,
}: PropsWithChildren<{ options: Options }>) => {
  const [isDarkMode] = useAtom(isDarkModeAtom);
  const theme = isDarkMode ? darkTheme : lightTheme;

  const [{ cache, flush }] = useState(() => {
    const cache = createCache({ key: "mui-theme" });
    cache.compat = true;
    // eslint-disable-next-line @typescript-eslint/unbound-method
    const prevInsert = cache.insert;
    let inserted = [] as string[];
    cache.insert = (...args) => {
      const serialized = args[1];
      if (cache.inserted[serialized.name] === undefined) {
        inserted.push(serialized.name);
      }
      return prevInsert(...args);
    };
    const flush = () => {
      const prevInserted = inserted;
      inserted = [];
      return prevInserted;
    };
    return { cache, flush };
  });

  useServerInsertedHTML(() => {
    const names = flush();
    if (names.length === 0) {
      return null;
    }
    let styles = "";
    for (const name of names) {
      styles += cache.inserted[name];
    }
    return (
      <style
        key={cache.key}
        data-emotion={`${cache.key} ${names.join(" ")}`}
        dangerouslySetInnerHTML={{
          __html: styles,
        }}
      />
    );
  });

  return (
    <CacheProvider value={cache}>
      <ThemeProvider theme={theme}>
        <CssBaseline />
        {children}
      </ThemeProvider>
    </CacheProvider>
  );
};

export default ThemeRegistry;

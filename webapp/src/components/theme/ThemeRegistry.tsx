"use client";

import * as React from "react";
import { ThemeProvider, CssBaseline } from "@mui/material";
import NextEmotionCacheProvider from "./NextEmotionCacheProvider";
import { darkTheme, lightTheme } from "./theme";
import { useAtom } from "jotai";
import { isDarkModeAtom } from "@/store/theme";

const ThemeRegistry = ({ children }: React.PropsWithChildren) => {
  const [isDarkMode] = useAtom(isDarkModeAtom);
  const theme = isDarkMode ? darkTheme : lightTheme;

  return (
    <NextEmotionCacheProvider options={{ key: "mui" }}>
      <ThemeProvider theme={theme}>
        <CssBaseline />
        {children}
      </ThemeProvider>
    </NextEmotionCacheProvider>
  );
};

export default ThemeRegistry;

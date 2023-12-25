"use client";

import { type PropsWithChildren, useState } from "react";
import { ThemeProvider } from "@mui/material";
import NavBar from "@/components/navigation/NavBar";
import { darkTheme, lightTheme } from "@/styles/theme";

const Layout = ({ children }: PropsWithChildren) => {
  const [isDarkMode, setDarkMode] = useState(false);
  const theme = isDarkMode ? darkTheme : lightTheme;

  return (
    <ThemeProvider theme={theme}>
      <NavBar isDarkMode={isDarkMode} setDarkMode={setDarkMode} />
      {children}
    </ThemeProvider>
  );
};

export default Layout;

/// <reference types="react-scripts" />

declare module "@mui/material/styles" {
  interface Theme {
    isDarkMode?: boolean;
  }
  interface ThemeOptions {
    isDarkMode?: boolean;
  }
}

export {};

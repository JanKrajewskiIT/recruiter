import { Roboto } from "next/font/google";
import { createTheme } from "@mui/material";

const roboto = Roboto({
  weight: ["300", "400", "500", "700"],
  subsets: ["latin"],
  display: "swap",
});

const palette = {
  brand: "#8b0036",
};

const lightTheme = createTheme({
  isDarkMode: false,
  palette: {
    mode: "light",
    background: {
      default: "#eeeff1",
    },
  },
  typography: {
    fontFamily: roboto.style.fontFamily,
  },
  components: {
    MuiAppBar: {
      styleOverrides: {
        colorPrimary: {
          background: palette.brand,
          color: "#ffffff",
        },
      },
    },
  },
});

const darkTheme = createTheme({
  isDarkMode: true,
  palette: {
    mode: "dark",
  },
  typography: {
    fontFamily: roboto.style.fontFamily,
  },
  components: {
    MuiAppBar: {
      styleOverrides: {
        colorPrimary: {
          border: "#8b0036",
        },
      },
    },
  },
});

export { palette, lightTheme, darkTheme };

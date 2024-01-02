import { Roboto } from "next/font/google";
import { createTheme } from "@mui/material";

const roboto = Roboto({
  weight: ["300", "400", "500", "700"],
  subsets: ["latin"],
  display: "swap",
});

const palette = {
  brand: "#8b0036",
  colorGray0: "#ffffff",
  colorGray10: "#eeeff1",
  colorGray20: "#d4d7dc",
  colorGray30: "#b8bcc5",
  colorGray40: "#9ba2af",
  colorGray50: "#858d9d",
  colorGray60: "#707a8c",
  colorGray70: "#626b7b",
  colorGray80: "#515865",
  colorGray90: "#404550",
  colorGray100: "#2d3138",
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

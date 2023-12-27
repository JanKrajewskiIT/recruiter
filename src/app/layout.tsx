import type { Metadata } from "next";
import { Inter } from "next/font/google";
import { AppRouterCacheProvider } from "@mui/material-nextjs/v14-appRouter";
import { type PropsWithChildren } from "react";
import ThemeRegistry from "@/styles/ThemeRegistry";
import NavBar from "@/components/navigation/NavBar";
import { Container } from "@mui/material";

import "../styles/globals.css";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "Recruiter",
  description: "App for managing recrutation process",
};

const RootLayout = ({ children }: PropsWithChildren) => (
  <html lang="en">
    <body className={inter.className}>
      <AppRouterCacheProvider>
        <ThemeRegistry options={{ key: "mui-theme" }}>
          <NavBar />
          <main>
            <Container>{children}</Container>
          </main>
        </ThemeRegistry>
      </AppRouterCacheProvider>
    </body>
  </html>
);

export default RootLayout;

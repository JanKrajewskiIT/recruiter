import type { Metadata } from "next";
import { Inter } from "next/font/google";
import { type PropsWithChildren } from "react";
import NavBar from "@/components/navigation/NavBar";
import { Container } from "@mui/material";

import "../styles/globals.css";
import ThemeRegistry from "@/components/theme/ThemeRegistry";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "Recruiter",
  description: "App for managing recrutation process",
};

const RootLayout = ({ children }: PropsWithChildren) => (
  <html lang="en">
    <body className={inter.className}>
      <ThemeRegistry>
        <NavBar />
        <main>
          <Container>{children}</Container>
        </main>
      </ThemeRegistry>
    </body>
  </html>
);

export default RootLayout;

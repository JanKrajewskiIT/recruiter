import type { Metadata } from "next";
import { Inter } from "next/font/google";
import { type PropsWithChildren } from "react";
import NavBar from "@/components/navigation/NavBar";

import "../styles/globals.css";
import ThemeRegistry from "@/components/theme/ThemeRegistry";
import NextAuthProvider from "@/components/auth/NextAuthProvider";
import { Container } from "@mui/material";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "Recruiter",
  description: "App for managing recrutation process",
};

const RootLayout = ({ children }: PropsWithChildren) => (
  <html lang="en">
    <body className={inter.className}>
      <ThemeRegistry>
        <NextAuthProvider>
          <NavBar />
          <main>
            <Container>{children}</Container>
          </main>
        </NextAuthProvider>
      </ThemeRegistry>
    </body>
  </html>
);

export default RootLayout;

import type { Metadata } from "next";
import { Inter } from "next/font/google";
import { AppRouterCacheProvider } from "@mui/material-nextjs/v14-appRouter";
import "../styles/globals.css";
import Navigation from "@/components/navigation/Navigation";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "Recruiter",
  description: "App for managing recrutation process",
};

const RootLayout = ({ children }: { children: React.ReactNode }) => (
  <html lang="en">
    <body className={inter.className}>
      <AppRouterCacheProvider>
        <Navigation />
        {children}
      </AppRouterCacheProvider>
    </body>
  </html>
);

export default RootLayout;

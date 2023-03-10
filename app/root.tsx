import { ThemeProvider } from '@mui/material';
import type { MetaFunction } from '@remix-run/node';
import {
  Links,
  LiveReload,
  Meta,
  Outlet,
  Scripts,
  ScrollRestoration,
} from '@remix-run/react';
import HomeNavBar from './components/HomeNavBar';
import theme from './styles/pallette';

export const meta: MetaFunction = () => ({
  charset: 'utf-8',
  title: 'EWU Basketball Stats Manager',
  viewport: 'width=device-width,initial-scale=1',
});

export default function App() {
  return (
    <Document>
      <ThemeProvider theme={theme}>
        <HomeNavBar />
        <Outlet />
      </ThemeProvider>
    </Document>
  );
}

interface Props {
  children?: React.ReactNode;
}

function Document({ children }: Props) {
  return (
    <html lang="en">
      <head>
        <link
          href="https://fonts.googleapis.com/css2?family=Tilt+Warp&display=swap"
          rel="stylesheet"
        />
        <Meta />
        <Links />
      </head>
      <body style={{ margin: '0px' }}>
        {children}
        <ScrollRestoration />
        <Scripts />
        <LiveReload />
      </body>
    </html>
  );
}

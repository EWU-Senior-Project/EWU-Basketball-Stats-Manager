import { createTheme } from '@mui/material';

const colors = {
  black: '#000000',
  white: '#ffffff',
  red: '#b7142e',
};

const theme = createTheme({
  components: {
    MuiButton: {
      variants: [
        {
          props: {},
          style: {
            fontFamily: 'Tilt Warp',
            fontSize: '16px',
          },
        },
      ],
    },
    MuiTypography: {
      variants: [
        {
          props: { variant: 'h1' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
        {
          props: { variant: 'h1' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
        {
          props: { variant: 'h2' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
        {
          props: { variant: 'h3' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
        {
          props: { variant: 'h4' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
        {
          props: { variant: 'h5' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
        {
          props: { variant: 'h6' },
          style: {
            fontFamily: 'Tilt Warp',
          },
        },
      ],
    },
  },
  palette: {
    primary: {
      main: colors.red,
    },
    secondary: {
      main: colors.black,
    },
    info: {
      main: colors.white,
    },
    text: {
      primary: colors.black,
      secondary: colors.white,
    },
  },
});
export default theme;

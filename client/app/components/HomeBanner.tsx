import { Box, Stack, Typography } from '@mui/material';
import EwuLogo from './EwuLogo';

const HomeBanner = (props: { children?: JSX.Element | JSX.Element[] }) => {
  const { children } = props;
  return (
    <Stack
      direction="row"
      justifyContent="space-between"
      p={2}
      style={{
        background: 'linear-gradient(to right, #b7142e, #5e0816',
      }}
    >
      <Box pt={3}>
        <Typography variant="h3" color="text.secondary">
          EASTERN WASHINGTON UNIVERSITY
        </Typography>
        {children}
      </Box>
      <EwuLogo />
    </Stack>
  );
};
export default HomeBanner;

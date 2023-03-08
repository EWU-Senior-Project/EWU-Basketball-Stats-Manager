import { Typography } from '@mui/material';
import EwuLogo from './EwuLogo';

const HomeBanner = () => {
  return (
    <div
      style={{
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        height: '132px',
        backgroundImage: 'linear-gradient(to right, #b7142e, #5e0816',
      }}
    >
      <Typography
        style={{ paddingLeft: '1em' }}
        variant="h3"
        color="text.secondary"
      >
        EASTERN WASHINGTON UNIVERSITY
      </Typography>
      <div style={{ paddingRight: '1em' }}>
        <EwuLogo />
      </div>
    </div>
  );
};
export default HomeBanner;

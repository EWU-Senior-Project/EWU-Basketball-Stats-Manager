import { AppBar, Button, Toolbar } from '@mui/material';
import { Link } from '@remix-run/react';

const buttons = [
  {
    name: 'My Team',
    to: '/my-team',
  },
  {
    name: 'Opponents',
    to: '/opponents',
  },
  {
    name: 'Scouts',
    to: '/scouts',
  },
  {
    name: 'Plays',
    to: '/plays',
  },
  {
    name: 'Videos',
    to: '/videos',
  },
];

const buttonList = buttons.map((button) => (
  <Link style={{ textDecoration: 'none' }} to={button.to} key={button.name}>
    <Button color="info" key={button.name}>
      {button.name}
    </Button>
  </Link>
));

const HomeNavBar = () => {
  return (
    <AppBar position="relative" color="secondary">
      <Toolbar sx={{ gap: '1em' }}>{buttonList}</Toolbar>
    </AppBar>
  );
};
export default HomeNavBar;

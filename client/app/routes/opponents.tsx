import { Outlet } from '@remix-run/react';
import ButtonList from '~/components/ButtonList';
import HomeBanner from '~/components/HomeBanner';

const buttons = [
  {
    name: 'All Teams',
    to: 'all-teams',
  },
  {
    name: 'Scheduled',
    to: 'scheduled',
  },
];

const Opponents = () => {
  return (
    <>
      <HomeBanner>
        <ButtonList buttons={buttons} />
      </HomeBanner>
      <Outlet />
    </>
  );
};

export default Opponents;

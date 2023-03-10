import { Outlet } from '@remix-run/react';
import ButtonList from '~/components/ButtonList';
import HomeBanner from '~/components/HomeBanner';

const buttons = [
  {
    name: 'Opponent Scouts',
    to: 'opponent-scouts',
  },
  {
    name: 'Self Scouts',
    to: 'self-scouts',
  },
  {
    name: 'Offline Scouts',
    to: 'offline-scouts',
  },
  {
    name: 'Templates',
    to: 'templates',
  },
  {
    name: 'Archived',
    to: 'archived',
  },
];

const Scouts = () => {
  return (
    <>
      <HomeBanner>
        <ButtonList buttons={buttons} />
      </HomeBanner>
      <Outlet />
    </>
  );
};

export default Scouts;

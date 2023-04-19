import { Outlet } from '@remix-run/react';
import ButtonList from '~/components/ButtonList';
import HomeBanner from '~/components/HomeBanner';

const buttons = [
  {
    name: 'Plays',
    to: 'plays',
  },
  {
    name: 'Playbook',
    to: 'playbook',
  },
];

const Plays = () => {
  return (
    <>
      <HomeBanner>
        <ButtonList buttons={buttons} />
      </HomeBanner>
      <Outlet />
    </>
  );
};

export default Plays;

import { Outlet } from '@remix-run/react';
import ButtonList from '~/components/ButtonList';
import HomeBanner from '~/components/HomeBanner';
import type { IButton } from '~/interfaces/IButton';

const MyTeam = () => {
  const buttons: IButton[] = [
    {
      name: 'Analytics',
      to: 'analytics',
    },
    {
      name: 'Schedule',
      to: 'schedule',
    },
    {
      name: 'Roster',
      to: 'roster',
    },
    {
      name: 'Self Scouts',
      to: 'self-scouts',
    },
  ];

  return (
    <>
      <HomeBanner>
        <ButtonList buttons={buttons} />
      </HomeBanner>
      <Outlet />
    </>
  );
};

export default MyTeam;

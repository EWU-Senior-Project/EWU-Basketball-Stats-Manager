import { AppBar, Tab, Tabs } from '@mui/material';
import { useState } from 'react';
import BallControlTable from '~/components/Tables/BallControlTable';
import BoxScoreTable from '~/components/Tables/BoxScoreTable';
import DefenseTable from '~/components/Tables/DefenseTable';
import FastScoutFactorsTable from '~/components/Tables/FastScoutFactorsTable';
import FreeThrowShootersTable from '~/components/Tables/FreeThrowShootersTable';
import LineUpStatsTable from '~/components/Tables/LineUpStatsTable';
import PointsPerPeriodTable from '~/components/Tables/PointsPerPeriodTable';
import PossessionsPerGame from '~/components/Tables/PossessionsPerGame';
import ReboundersTable from '~/components/Tables/ReboundersTable';
import TeamStatsTable from '~/components/Tables/TeamStatsTable';
import ThreePointShootersTable from '~/components/Tables/ThreePointShootersTable';
import TopScorersTable from '~/components/Tables/TopScorersTable';

const Analytics = () => {
  const [value, setValue] = useState(0);

  return (
    <>
      <AppBar position="relative" color="transparent">
        <Tabs
          value={value}
          onChange={(e, newValue: number) => setValue(newValue)}
        >
          <Tab label="Dashboard" value={0} />
          <Tab label="Team Stats" value={1} />
        </Tabs>
      </AppBar>
      <div style={{ padding: '2em' }}>
        {value === 0 ? <Dashboard /> : <TeamStats />}
      </div>
    </>
  );
};

const Dashboard = () => {
  return (
    <>
      <FastScoutFactorsTable title={true} />
      <LineUpStatsTable title={true} />
      <div
        style={{
          display: 'flex',
          flexDirection: 'row',
          flexWrap: 'wrap',
          columnGap: '2em',
        }}
      >
        <PointsPerPeriodTable title={true} />
        <PossessionsPerGame title={true} />
      </div>
      <BoxScoreTable title={true} />
    </>
  );
};

const TeamStats = () => {
  return (
    <>
      <TeamStatsTable title={true} />
      <div
        style={{
          display: 'flex',
          flexDirection: 'row',
          flexWrap: 'wrap',
          columnGap: '2em',
        }}
      >
        <TopScorersTable title={true} />
        <ThreePointShootersTable title={true} />
      </div>
      <div
        style={{
          display: 'flex',
          flexDirection: 'row',
          flexWrap: 'wrap',
          columnGap: '2em',
        }}
      >
        <FreeThrowShootersTable title={true} />
        <ReboundersTable title={true} />
      </div>
      <div
        style={{
          display: 'flex',
          flexDirection: 'row',
          flexWrap: 'wrap',
          columnGap: '2em',
        }}
      >
        <BallControlTable title={true} />
        <DefenseTable title={true} />
      </div>
    </>
  );
};

export default Analytics;

import {
  AppBar,
  FormControl,
  MenuItem,
  OutlinedInput,
  Select,
  Tab,
  Tabs,
} from '@mui/material';
import { useState } from 'react';
import BallControlTable from '~/components/Tables/BallControlTable';
import BoxScoreTable from '~/components/Tables/BoxScoreTable';
import DefenseTable from '~/components/Tables/DefenseTable';
import FastScoutFactorsTable from '~/components/Tables/FastScoutFactorsTable';
import FreeThrowShootersTable from '~/components/Tables/FreeThrowShootersTable';
import LineUpStatsTable from '~/components/Tables/LineUpStatsTable';
import PointsPerPeriodTable from '~/components/Tables/PointsPerPeriodTable';
import PossessionsPerGame from '~/components/Tables/PossessionsPerGame';
import TeamStatsTable from '~/components/Tables/TeamStatsTable';
import ThreePointShootersTable from '~/components/Tables/ThreePointShootersTable';
import TopScorersTable from '~/components/Tables/TopScorersTable';
import TopReboundersTable from '~/components/Tables/TopReboundersTable';
import { json } from '@remix-run/node';
import { GetTopScorers } from '~/api/teamStatsApi.server';

export const loader = () => {
  const topScorers = GetTopScorers();
  console.log('DATA: ', topScorers);
  return topScorers;
};

export const action = () => {};

const Analytics = () => {
  const [value, setValue] = useState(0);

  return (
    <>
      <AppBar
        position="relative"
        color="transparent"
        style={{
          display: 'flex',
          flexDirection: 'row',
          justifyContent: 'space-between',
        }}
      >
        <Tabs
          value={value}
          onChange={(e, newValue: number) => setValue(newValue)}
        >
          <Tab label="Dashboard" value={0} />
          <Tab label="Team Stats" value={1} />
        </Tabs>
        <div>
          <FormControl
            sx={{ m: 1, minWidth: 180, '&>div': { height: '32px' } }}
          >
            <Select
              input={<OutlinedInput />}
              defaultValue={0}
              // onChange={(e) => setYear(e.target.value)}
            >
              <MenuItem value={0}>All Games</MenuItem>
              <MenuItem value={1}>Last 5</MenuItem>
              <MenuItem value={2}>Wins vs Losses</MenuItem>
              <MenuItem value={3}>Home vs Away</MenuItem>
              <MenuItem value={4}>Conf vs Non Conf</MenuItem>
            </Select>
          </FormControl>
          <FormControl
            sx={{ m: 1, minWidth: 120, '&>div': { height: '32px' } }}
          >
            <Select
              input={<OutlinedInput />}
              defaultValue={0}
              // onChange={(e) => setYear(e.target.value)}
            >
              <MenuItem value={0}>2022-2023</MenuItem>
              <MenuItem value={1}>2021-2022</MenuItem>
              <MenuItem value={2}>2020-2021</MenuItem>
              <MenuItem value={3}>2019-2020</MenuItem>
              <MenuItem value={4}>2018-2019</MenuItem>
              <MenuItem value={5}>2017-2018</MenuItem>
            </Select>
          </FormControl>
        </div>
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
        <TopReboundersTable title={true} />
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

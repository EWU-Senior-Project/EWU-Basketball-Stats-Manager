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
import AllGamesTable from '~/components/Tables/AllGamesTable';
import AwayGamesTable from '~/components/Tables/AwayGamesTable';
import ConferenceGamesTable from '~/components/Tables/ConferenceGamesTable';
import HomeGamesTable from '~/components/Tables/HomeGamesTable';
import Last5GamesTable from '~/components/Tables/Last5GamesTable';
import LossesTable from '~/components/Tables/LossesTable';
import WinsTable from '~/components/Tables/WinsTable';

const Schedule = () => {
  const [value, setValue] = useState(0);
  // const [year, setYear] = useState('');

  const currentTab = () => {
    switch (value) {
      case 0:
        return <AllGamesTable title />;
      case 1:
        return <ConferenceGamesTable title />;
      case 2:
        return <Last5GamesTable title />;
      case 3:
        return <WinsTable title />;
      case 4:
        return <LossesTable title />;
      case 5:
        return <HomeGamesTable title />;
      case 6:
        return <AwayGamesTable title />;
    }
  };

  return (
    <>
      <AppBar
        position="relative"
        color="transparent"
        sx={{ display: 'flex', flexDirection: 'row' }}
      >
        <FormControl sx={{ m: 1, minWidth: 120, '&>div': { height: '32px' } }}>
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
        <Tabs
          value={value}
          onChange={(_, newValue: number) => setValue(newValue)}
        >
          <Tab label="All Games" value={0} />
          <Tab label="Conference" value={1} />
          <Tab label="Last 5" value={2} />
          <Tab label="Wins" value={3} />
          <Tab label="Losses" value={4} />
          <Tab label="Home" value={5} />
          <Tab label="Away" value={6} />
        </Tabs>
      </AppBar>
      <div style={{ padding: '2em' }}>{currentTab()}</div>
    </>
  );
};

export default Schedule;

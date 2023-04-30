import { AppBar } from '@mui/material';

import CreateScoutingReportDialog from '~/components/CreateScoutingReport/CreateScoutingReportDialog';
import OpponentScoutsTable from '~/components/Tables/OpponentScoutsTable';

const OpponentScouts = () => {
  return (
    <>
      <AppBar
        position="relative"
        color="transparent"
        style={{
          height: '49px',
          display: 'flex',
          flexDirection: 'row',
          justifyContent: 'right',
          alignItems: 'center',
        }}
      >
        <CreateScoutingReportDialog />
      </AppBar>
      <div style={{ padding: '2em' }}>
        <OpponentScoutsTable />
      </div>
    </>
  );
};

export default OpponentScouts;

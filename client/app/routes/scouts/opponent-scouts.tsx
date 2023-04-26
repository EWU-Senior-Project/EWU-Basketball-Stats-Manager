import { AppBar, Button } from '@mui/material';
import { Link } from '@remix-run/react';
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
        <Link style={{ textDecoration: 'none' }} to="/create-scouting-report">
          <Button>Scouting Report Tool</Button>
        </Link>
        <CreateScoutingReportDialog />
      </AppBar>
      <div style={{ padding: '2em' }}>
        <OpponentScoutsTable />
      </div>
    </>
  );
};

export default OpponentScouts;

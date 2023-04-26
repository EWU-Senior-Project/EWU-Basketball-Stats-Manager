import { Box, Stack } from '@mui/material';
import ScoutingReportEditor from '~/components/CreateScoutingReport/ScoutingReportEditor';
import ScoutingReportPanel from '~/components/CreateScoutingReport/ScoutingReportPanel';
import { makeStyles } from '@mui/styles';

const useStyles = makeStyles({
  hidePrint: {},
  [`@media print`]: {
    hidePrint: {
      display: 'none',
    },
  },
});

const CreateScoutingReport = () => {
  const classes = useStyles();
  return (
    <Stack direction="row" height="100%">
      <div className={classes.hidePrint}>
        <ScoutingReportPanel />
      </div>

      <Box display="flex" justifyContent="center" flexGrow={1}>
        <ScoutingReportEditor />
      </Box>
    </Stack>
  );
};

export default CreateScoutingReport;

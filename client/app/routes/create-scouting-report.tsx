import { Box, Stack } from '@mui/material';
import ScoutingReportEditor from '~/components/CreateScoutingReport/ScoutingReportEditor';
import ScoutingReportPanel from '~/components/CreateScoutingReport/ScoutingReportPanel';

const CreateScoutingReport = () => {
  return (
    <Stack direction="row" height="100%">
      <ScoutingReportPanel />
      <Box display="flex" justifyContent="center" flexGrow={1}>
        <ScoutingReportEditor />
      </Box>
    </Stack>
  );
};

export default CreateScoutingReport;

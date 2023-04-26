import { Paper, Typography } from '@mui/material';

const ScoutingReportEditor = () => {
  return (
    <Paper
      sx={{
        display: 'flex',
        flexGrow: 1,
        maxWidth: '1000px',
        height: '1000px',
        padding: '50px',
        justifyContent: 'center',
      }}
      elevation={10}
    >
      <Typography variant="h3">THIS IS A REPORT</Typography>
    </Paper>
  );
};

export default ScoutingReportEditor;

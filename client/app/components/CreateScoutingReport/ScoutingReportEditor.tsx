import type { ReactJSXElement } from '@emotion/react/types/jsx-namespace';
import { Box, Container, Paper, Typography } from '@mui/material';

interface IProps {
  items: ReactJSXElement[];
}

const ScoutingReportEditor = ({ items }: IProps) => {
  return (
    <Paper
      sx={{
        marginTop: '2em',
        display: 'flex',
        flexGrow: 1,
        maxWidth: '1000px',
        height: '1000px',
        padding: '50px',
      }}
      elevation={10}
    >
      <Box display={'flex'} sx={{ flex: 1, flexDirection: 'column' }}>
        <Typography style={{ textAlign: 'center' }} variant="h3">
          THIS IS A REPORT
        </Typography>
        <Container
          style={{
            display: 'flex',
            flexDirection: 'row',
            maxWidth: '1000px',
            flexWrap: 'wrap',
            gap: '1em',
          }}
        >
          {items}
        </Container>
      </Box>
    </Paper>
  );
};

export default ScoutingReportEditor;

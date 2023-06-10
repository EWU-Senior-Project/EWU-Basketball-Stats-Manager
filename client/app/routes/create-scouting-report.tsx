import { Box, Stack } from '@mui/material';
import ScoutingReportEditor from '~/components/CreateScoutingReport/ScoutingReportEditor';
import ScoutingReportPanel from '~/components/CreateScoutingReport/ScoutingReportPanel';
import { makeStyles } from '@mui/styles';
import { useState } from 'react';
import type { ReactJSXElement } from '@emotion/react/types/jsx-namespace';

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
  const [items, setItems] = useState<ReactJSXElement[]>([]);

  const AddComponent = (item: ReactJSXElement) => {
    setItems([...items, item]);
  };

  return (
    <Stack direction="row" height="100%">
      <div className={classes.hidePrint}>
        <ScoutingReportPanel AddComponent={AddComponent} />
      </div>

      <Box display="flex" justifyContent="center" flexGrow={1}>
        <ScoutingReportEditor items={items} />
      </Box>
    </Stack>
  );
};

export default CreateScoutingReport;

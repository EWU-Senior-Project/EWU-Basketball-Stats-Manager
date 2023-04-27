import {
  Button,
  Typography,
  Dialog,
  DialogActions,
  DialogTitle,
} from '@mui/material';
import { useState } from 'react';
import CreateScoutingReportForm from './CreateScoutingReportForm';

const CreateScoutingReportDialog = () => {
  const [open, setOpen] = useState<boolean>(false);

  return (
    <>
      {/* dsf */}
      <Button
        variant="contained"
        style={{ height: '32px', marginRight: '2.2em' }}
        onClick={() => setOpen(true)}
      >
        <Typography>New Opponent Scout</Typography>
      </Button>
      <Dialog open={open} fullWidth>
        <DialogTitle>New Opponent Scout</DialogTitle>
        <CreateScoutingReportForm />
        <DialogActions>
          <Button variant="outlined" onClick={() => setOpen(false)}>
            Cancel
          </Button>
          <Button variant="contained" onClick={() => setOpen(false)}>
            Create
          </Button>
        </DialogActions>
      </Dialog>
    </>
  );
};
export default CreateScoutingReportDialog;

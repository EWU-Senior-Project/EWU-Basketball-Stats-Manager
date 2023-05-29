import { Card } from '@mui/material';
import { makeStyles } from '@mui/styles';

import SlateEditor from '~/components/SlateEditor';

const useStyles = makeStyles({
  card: {
    width: '100%',
    height: '50px',
  },
});

const SectionHeader = () => {
  const classes = useStyles();
  return (
    <Card variant="outlined" className={classes.card}>
      <SlateEditor type={'header'} />
    </Card>
  );
};

export default SectionHeader;

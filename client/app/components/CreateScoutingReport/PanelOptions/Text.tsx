import { Card } from '@mui/material';
import { makeStyles } from '@mui/styles';
import SlateEditor from '~/components/SlateEditor';

const useStyles = makeStyles({
  card: {
    display: 'flex',
    width: '48%',
    height: '200px',
    flexDirection: 'column',
  },
});

const Text = () => {
  const classes = useStyles();
  return (
    <Card variant="outlined" className={classes.card}>
      <SlateEditor type={'text'} />
    </Card>
  );
};

export default Text;

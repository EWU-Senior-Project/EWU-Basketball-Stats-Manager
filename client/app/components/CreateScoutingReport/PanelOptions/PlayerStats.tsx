import {
  Card,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  Typography,
} from '@mui/material';
import { makeStyles } from '@mui/styles';
import theme from '~/styles/pallette';

const useStyles = makeStyles({
  card: {
    display: 'flex',
    width: '48.8%',
    height: '200px',
    flexDirection: 'column',
  },
});

const PlayerStats = () => {
  const classes = useStyles();
  return (
    <Card variant="outlined" className={classes.card}>
      <Table>
        <TableHead sx={{ background: theme.palette.secondary.light }}>
          <TableRow>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                PTS
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                FGM-A
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                FG%
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                3PM-A
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                3P%
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                FTM-A
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                REB
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                ORB
              </Typography>
            </TableCell>
            <TableCell sx={{ padding: '4px' }} align="center">
              <Typography fontSize={'10px'} color="text.secondary">
                AST
              </Typography>
            </TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          <TableRow>
            <TableCell align="center">1</TableCell>
            <TableCell align="center">2</TableCell>
            <TableCell align="center">3</TableCell>
            <TableCell align="center">4</TableCell>
            <TableCell align="center">1</TableCell>
            <TableCell align="center">2</TableCell>
            <TableCell align="center">3</TableCell>
            <TableCell align="center">4</TableCell>
            <TableCell align="center">4</TableCell>
          </TableRow>
        </TableBody>
      </Table>
    </Card>
  );
};

export default PlayerStats;

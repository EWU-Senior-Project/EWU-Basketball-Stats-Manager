import {
  Typography,
  TableContainer,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
} from '@mui/material';
import theme from '~/styles/pallette';

type IProps = {
  title?: boolean;
};

const PointsPerPeriodTable = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flexGrow: 1 }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          POINTS PER PERIOD
        </Typography>
      )}

      <TableContainer component={Paper}>
        <Table>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">TEAM</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">1ST</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">2ND</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">GAME</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {pointsPerPeriodRows.map((row) => (
              <TableRow key={row.team}>
                <TableCell>{row.team}</TableCell>
                <TableCell align="right">{row.first}</TableCell>
                <TableCell align="right">{row.second}</TableCell>
                <TableCell align="right">{row.game}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default PointsPerPeriodTable;

function createData(team: string, first: number, second: number, game: number) {
  return { team, first, second, game };
}

const pointsPerPeriodRows = [
  createData('Eastern Washington', 0.0, 0.0, 0.0),
  createData('All Opponents', 0.0, 0.0, 0.0),
];

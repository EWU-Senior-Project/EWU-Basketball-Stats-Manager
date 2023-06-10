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
  title: boolean;
};

const TeamStatsTable = ({ title }: IProps) => {
  return (
    <>
      {title && (
        <Typography variant="h5" sx={{ paddingBottom: '.5em' }}>
          TEAM STATS
        </Typography>
      )}
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }}>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">STAT</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">ALL (OFF)</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">LAST 5 (OFF)</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">WINS (OFF)</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">LOSSES (OFF)</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">HOME (OFF)</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">AWAY (OFF)</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {teamStatsRows.map((row) => (
              <TableRow key={row.stat}>
                <TableCell>
                  <strong>{row.stat}</strong>
                </TableCell>
                <TableCell align="right">{row.all}</TableCell>
                <TableCell align="right">{row.last5}</TableCell>
                <TableCell align="right">{row.wins}</TableCell>
                <TableCell align="right">{row.losses}</TableCell>
                <TableCell align="right">{row.home}</TableCell>
                <TableCell align="right">{row.away}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </>
  );
};

export default TeamStatsTable;

function createData(
  stat: string,
  all: number,
  last5: number,
  wins: number,
  losses: number,
  home: number,
  away: number
) {
  return { stat, all, last5, wins, losses, home, away };
}

const teamStatsRows = [
  createData('PTS', 0, 0, 0, 0, 0, 0),
  createData('FGM-A', 0, 0, 0, 0, 0, 0),
  createData('FG%', 0, 0, 0, 0, 0, 0),
  createData('3PM-A', 0, 0, 0, 0, 0, 0),
  createData('3P%', 0, 0, 0, 0, 0, 0),
  createData('FTM-A', 0, 0, 0, 0, 0, 0),
  createData('FT%', 0, 0, 0, 0, 0, 0),
  createData('AST', 0, 0, 0, 0, 0, 0),
  createData('TO', 0, 0, 0, 0, 0, 0),
  createData('ORB', 0, 0, 0, 0, 0, 0),
  createData('DRB', 0, 0, 0, 0, 0, 0),
  createData('REB', 0, 0, 0, 0, 0, 0),
  createData('STL', 0, 0, 0, 0, 0, 0),
  createData('BLK', 0, 0, 0, 0, 0, 0),
];

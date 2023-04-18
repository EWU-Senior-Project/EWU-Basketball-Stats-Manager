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

const TopScorersTable = ({ title }: IProps) => {
  return (
    <div
      style={{
        display: 'flex',
        flexDirection: 'column',
        flex: '1 1 0',
      }}
    >
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          TOP SCORERS
        </Typography>
      )}
      <TableContainer component={Paper}>
        <Table>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">#</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">PLAYER</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">PTS</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FGM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FG%</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {topScorerRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{row.pts}</TableCell>
                <TableCell align="right">{`${row.fgMade}-${row.fgAttempted}`}</TableCell>
                <TableCell align="right">{row.fgPercentage}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default TopScorersTable;

function createData(
  jerseyNumber: number,
  player: string,
  pts: number,
  fgMade: number,
  fgAttempted: number,
  fgPercentage: number
) {
  return { jerseyNumber, player, pts, fgMade, fgAttempted, fgPercentage };
}

const topScorerRows = Array.from({ length: 5 }, () =>
  createData(2, 'bond, james bond', 0, 0, 0, 0)
);

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

const LineUpStatsTable = ({ title }: IProps) => {
  return (
    <>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          LINEUP STATS
        </Typography>
      )}
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }}>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">Player</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">GP</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">MIN</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">ORTG</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">DRTG</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">NRTG</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">EFG%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">TS%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">ORB%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">DRB%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">TO%</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {lineUpStatsRows.map((row) => (
              <TableRow key={row.player}>
                <TableCell>{row.player}</TableCell>
                <TableCell align="right">{row.gp}</TableCell>
                <TableCell align="right">{row.min}</TableCell>
                <TableCell align="right">{row.ortg}</TableCell>
                <TableCell align="right">{row.drtg}</TableCell>
                <TableCell align="right">{row.nrtg}</TableCell>
                <TableCell align="right">{row.efg}</TableCell>
                <TableCell align="right">{row.ts}</TableCell>
                <TableCell align="right">{row.orb}</TableCell>
                <TableCell align="right">{row.drb}</TableCell>
                <TableCell align="right">{row.to}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </>
  );
};

export default LineUpStatsTable;

function createData(
  player: string,
  gp: number,
  min: number,
  ortg: number,
  drtg: number,
  nrtg: number,
  efg: number,
  ts: number,
  orb: number,
  drb: number,
  to: number
) {
  return { player, gp, min, ortg, drtg, nrtg, efg, ts, orb, drb, to };
}

const lineUpStatsRows = Array.from({ length: 10 }, () =>
  createData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
);

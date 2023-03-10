import {
  Paper,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Typography,
} from '@mui/material';
import theme from '~/styles/pallette';

function createFSData(
  stat: string,
  off: number,
  def: number,
  bsa: number,
  dia: number
) {
  return { stat, off, def, bsa, dia };
}

const fsRows = [
  createFSData('eFG%', 0, 0, 0, 0),
  createFSData('TS%', 0, 0, 0, 0),
  createFSData('TO%', 0, 0, 0, 0),
  createFSData('AST%', 0, 0, 0, 0),
  createFSData('REB%', 0, 0, 0, 0),
  createFSData('FT-R', 0, 0, 0, 0),
  createFSData('FT%', 0, 0, 0, 0),
];

function createLSData(
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

const lsRows = [
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Obama', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
  createLSData('Joe Smith', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
];

const Analytics = () => {
  return (
    <div style={{ padding: '2em' }}>
      <Typography variant="h5" sx={{ paddingBottom: '.5em' }}>
        FASTSCOUT FACTORS
      </Typography>
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }}>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">STATS</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">EWU OFF</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">EWU DEF</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">BIG SKY AVG</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">D-I AVG</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {fsRows.map((row) => (
              <TableRow key={row.stat}>
                <TableCell>
                  <strong>{row.stat}</strong>
                </TableCell>
                <TableCell align="right">{row.off}</TableCell>
                <TableCell align="right">{row.def}</TableCell>
                <TableCell align="right">{row.bsa}</TableCell>
                <TableCell align="right">{row.dia}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Typography
        variant="h5"
        sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
      >
        LINEUP STATS
      </Typography>
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
            {lsRows.map((row) => (
              <TableRow key={row.player}>
                <TableCell>
                  <strong>{row.player}</strong>
                </TableCell>
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
    </div>
  );
};

export default Analytics;

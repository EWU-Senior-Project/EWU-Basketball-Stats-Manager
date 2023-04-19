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

type IProps = {
  title: boolean;
};

const FastScoutFactorsTable = ({ title }: IProps) => {
  return (
    <>
      {title && (
        <Typography variant="h5" sx={{ paddingBottom: '.5em' }}>
          FASTSCOUT FACTORS
        </Typography>
      )}
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
    </>
  );
};

export default FastScoutFactorsTable;

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

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

const DefenseTable = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flex: '1 1 0' }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          DEFENSE
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
                <Typography color="text.secondary">STL</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">BLK</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {defenseRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{row.stl}</TableCell>
                <TableCell align="right">{row.blk}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default DefenseTable;

function createData(
  jerseyNumber: number,
  player: string,
  stl: number,
  blk: number
) {
  return {
    jerseyNumber,
    player,
    stl,
    blk,
  };
}

const defenseRows = Array.from({ length: 5 }, () =>
  createData(2, 'Russel Westbrick', 0, 0)
);

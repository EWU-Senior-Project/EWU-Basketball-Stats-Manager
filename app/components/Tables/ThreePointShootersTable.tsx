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

const ThreePointShootersTable = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flexGrow: 1 }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          3PT SHOOTERS
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
                <Typography color="text.secondary">3PM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">3P%</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {threePointShootersRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{`${row.threeMade}-${row.threeAttempted}`}</TableCell>
                <TableCell align="right">{row.threePercentage}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default ThreePointShootersTable;

function createData(
  jerseyNumber: number,
  player: string,
  threeMade: number,
  threeAttempted: number,
  threePercentage: number
) {
  return {
    jerseyNumber,
    player,
    threeMade,
    threeAttempted,
    threePercentage,
  };
}

const threePointShootersRows = Array.from({ length: 5 }, () =>
  createData(2, 'Russel Westbrick', 0, 0, 0)
);

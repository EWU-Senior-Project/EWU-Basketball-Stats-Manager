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

const FreeThrowShootersTable = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flex: '1 1 0' }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          FREE THROW SHOOTERS
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
                <Typography color="text.secondary">FTM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FT%</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {freeThrowShootersRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{`${row.ftMade}-${row.ftAttempted}`}</TableCell>
                <TableCell align="right">{row.ftPercentage}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default FreeThrowShootersTable;

function createFreeThrowShootersData(
  jerseyNumber: number,
  player: string,

  ftMade: number,
  ftAttempted: number,
  ftPercentage: number
) {
  return {
    jerseyNumber,
    player,

    ftMade,
    ftAttempted,
    ftPercentage,
  };
}

const freeThrowShootersRows = Array.from({ length: 5 }, () =>
  createFreeThrowShootersData(2, 'Russel Westbrick', 0, 0, 0)
);

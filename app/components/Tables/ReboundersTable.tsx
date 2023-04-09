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

const ReboundersTable = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flexGrow: 1 }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          TOP REBOUNDERS
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
                <Typography color="text.secondary">REB</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">ORB</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">DRB</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {reboundersRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{row.reb}</TableCell>
                <TableCell align="right">{row.orb}</TableCell>
                <TableCell align="right">{row.drb}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default ReboundersTable;

function createData(
  jerseyNumber: number,
  player: string,
  reb: number,
  orb: number,
  drb: number
) {
  return {
    jerseyNumber,
    player,
    reb,
    orb,
    drb,
  };
}

const reboundersRows = Array.from({ length: 5 }, () =>
  createData(2, 'Russel Westbrick', 0, 0, 0)
);

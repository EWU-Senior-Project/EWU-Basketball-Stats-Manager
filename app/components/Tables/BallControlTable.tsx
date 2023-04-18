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

const BallControlTable = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flex: '1 1 0' }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          BALL CONTROL
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
                <Typography color="text.secondary">AST</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">TO</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">A/TO</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {ballControlRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{row.ast}</TableCell>
                <TableCell align="right">{row.to}</TableCell>
                <TableCell align="right">{row.ast_to}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default BallControlTable;

function createData(
  jerseyNumber: number,
  player: string,
  ast: number,
  to: number,
  ast_to: number
) {
  return {
    jerseyNumber,
    player,
    ast,
    to,
    ast_to,
  };
}

const ballControlRows = Array.from({ length: 5 }, () =>
  createData(2, 'Russel Westbrick', 0, 0, 0)
);

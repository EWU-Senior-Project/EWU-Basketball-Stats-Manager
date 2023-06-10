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
import { useLoaderData } from '@remix-run/react';
import theme from '~/styles/pallette';

type IProps = {
  title: boolean;
};

type player = {
  jersey: number;
  displayName: string;
  pts: number;
  fgm: number;
  fga: number;
  fgp: number;
};

const TopScorersTable = ({ title }: IProps) => {
  const players = useLoaderData<player[]>();
  console.log(players);
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
            {players.map((player) => (
              <TableRow key={player.jersey}>
                <TableCell>{player.jersey}</TableCell>
                <TableCell align="right">{player.displayName}</TableCell>
                <TableCell align="right">{player.pts}</TableCell>
                <TableCell align="right">{`${player.fgm}-${player.fga}`}</TableCell>
                <TableCell align="right">{player.fgp}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default TopScorersTable;

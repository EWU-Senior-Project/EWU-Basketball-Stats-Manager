import {
  TableContainer,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  Typography,
  TableBody,
  Button,
} from '@mui/material';
import { Link } from '@remix-run/react';

import theme from '~/styles/pallette';

const OpponentScoutsTable = () => {
  return (
    <>
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }}>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="center">
                <Typography color="text.secondary">Logo</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Scout</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Season</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Team</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Game Date</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Prepared By</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Last Modified</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary">Status</Typography>
              </TableCell>
              <TableCell align="center">
                <Typography color="text.secondary"></Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {scoutingReports.map((row) => (
              <TableRow key={row.scout}>
                <TableCell align="center">{row.logo}</TableCell>

                <TableCell align="center">{row.scout}</TableCell>
                <TableCell align="center">{row.season}</TableCell>
                <TableCell align="center">{row.team}</TableCell>
                <TableCell align="center">{row.gameDate}</TableCell>
                <TableCell align="center">{row.preparedBy}</TableCell>
                <TableCell align="center">{row.lastModified}</TableCell>
                <TableCell align="center">{row.status}</TableCell>

                <TableCell align="center">
                  <Link to="/create-scouting-report">
                    <Button>Open</Button>
                  </Link>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </>
  );
};

export default OpponentScoutsTable;

function createData(
  logo: string,
  scout: string,
  season: string,
  team: string,
  gameDate: string,
  preparedBy: string,
  lastModified: string,
  status: string
) {
  return {
    logo,
    scout,
    season,
    team,
    gameDate,
    preparedBy,
    lastModified,
    status,
  };
}

const scoutingReports = Array.from({ length: 100 }, () =>
  createData(
    'Logo',
    'Duke',
    '2022-2023',
    'Duke',
    'jun 09, 2023',
    'Mark Darnall',
    'Apr 17, 2023',
    'not implemented'
  )
);

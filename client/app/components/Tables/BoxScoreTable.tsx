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

const BoxScoreTable = ({ title }: IProps) => {
  return (
    <>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          BOX SCORE
        </Typography>
      )}
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }}>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">#</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">Player</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">GP-GS</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">MIN</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FGM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FG%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">3PM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">3P%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">3P-R</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">2PM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">2P%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FTM-A</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">FT%</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">PTS</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">ORB</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">DRB</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">REB</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">AST</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">TO</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">STL</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">BLK</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">PF</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {boxScoreRows.map((row) => (
              <TableRow key={row.jerseyNumber}>
                <TableCell>{row.jerseyNumber}</TableCell>
                <TableCell align="right">{row.player}</TableCell>
                <TableCell align="right">{`${row.gamesPlayed}-${row.gamesStarted}`}</TableCell>
                <TableCell align="right">{row.min}</TableCell>
                <TableCell align="right">{`${row.fgMade}-${row.fgAttempted}`}</TableCell>
                <TableCell align="right">{row.fgPercentage}</TableCell>
                <TableCell align="right">{`${row.threeMade}-${row.threeAttempted}`}</TableCell>
                <TableCell align="right">{row.threePercentage}</TableCell>
                <TableCell align="right">{row.threeRate}</TableCell>
                <TableCell align="right">{`${row.twoMade}-${row.twoAttempted}`}</TableCell>
                <TableCell align="right">{row.twoPercentage}</TableCell>
                <TableCell align="right">{`${row.ftMade}-${row.ftAttempted}`}</TableCell>
                <TableCell align="right">{row.ftPercentage}</TableCell>
                <TableCell align="right">{row.pts}</TableCell>
                <TableCell align="right">{row.orb}</TableCell>
                <TableCell align="right">{row.drb}</TableCell>
                <TableCell align="right">{row.reb}</TableCell>
                <TableCell align="right">{row.ast}</TableCell>
                <TableCell align="right">{row.to}</TableCell>
                <TableCell align="right">{row.stl}</TableCell>
                <TableCell align="right">{row.blk}</TableCell>
                <TableCell align="right">{row.pf}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </>
  );
};

export default BoxScoreTable;

function createData(
  jerseyNumber: number,
  player: string,
  gamesPlayed: number,
  gamesStarted: number,
  min: number,
  fgMade: number,
  fgAttempted: number,
  fgPercentage: number,
  threeMade: number,
  threeAttempted: number,
  threePercentage: number,
  threeRate: number,
  twoMade: number,
  twoAttempted: number,
  twoPercentage: number,
  twoRate: number,
  ftMade: number,
  ftAttempted: number,
  ftPercentage: number,
  pts: number,
  orb: number,
  drb: number,
  reb: number,
  ast: number,
  to: number,
  stl: number,
  blk: number,
  pf: number
) {
  return {
    jerseyNumber,
    player,
    gamesPlayed,
    gamesStarted,
    min,
    fgMade,
    fgAttempted,
    fgPercentage,
    threeMade,
    threeAttempted,
    threePercentage,
    threeRate,
    twoMade,
    twoAttempted,
    twoPercentage,
    twoRate,
    ftMade,
    ftAttempted,
    ftPercentage,
    pts,
    orb,
    drb,
    reb,
    ast,
    to,
    stl,
    blk,
    pf,
  };
}

const boxScoreRows = Array.from({ length: 10 }, () =>
  createData(
    2,
    'Joe',
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0
  )
);

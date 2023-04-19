import {
  TableContainer,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  Typography,
  TableBody,
} from '@mui/material';
import theme from '~/styles/pallette';

type IProps = {
  title?: boolean;
};

const WinsTable = ({ title }: IProps) => {
  return (
    <>
      {title && (
        <Typography variant="h5" sx={{ paddingBottom: '.5em' }}>
          Wins
        </Typography>
      )}
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }}>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="left">
                <Typography color="text.secondary">Date</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">Opponent</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">Location</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">Result</Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">Video</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {winsRows.map((row) => (
              <TableRow key={row.date}>
                <TableCell>
                  <strong>{row.date}</strong>
                </TableCell>
                <TableCell align="right">{row.opponent}</TableCell>
                <TableCell align="right">{row.location}</TableCell>
                <TableCell align="right">{row.result}</TableCell>
                <TableCell align="right">{row.video}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </>
  );
};

export default WinsTable;

function createWinsData(
  date: string,
  opponent: string,
  location: string,
  result: string,
  video: any
) {
  return { date, opponent, location, result, video };
}

const winsRows = [
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
  createWinsData('00/00/0000', 'Gonzaga', 'Spokane', 'W', '[]'),
];

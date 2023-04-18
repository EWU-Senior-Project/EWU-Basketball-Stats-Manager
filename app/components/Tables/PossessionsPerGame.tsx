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
  title?: boolean;
};

const PossessionsPerGame = ({ title }: IProps) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', flex: '1 1 0' }}>
      {title && (
        <Typography
          variant="h5"
          sx={{ paddingTop: '2em', paddingBottom: '.5em' }}
        >
          PACE (POSSESSIONS PER GAME)
        </Typography>
      )}

      <TableContainer component={Paper}>
        <Table>
          <TableHead sx={{ background: theme.palette.secondary.light }}>
            <TableRow>
              <TableCell align="right">
                <Typography color="text.secondary">
                  Eastern Washington
                </Typography>
              </TableCell>
              <TableCell align="right">
                <Typography color="text.secondary">D1 FCS</Typography>
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            <TableRow>
              <TableCell align="right">0.0</TableCell>
              <TableCell align="right">0.0</TableCell>
            </TableRow>
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
};

export default PossessionsPerGame;

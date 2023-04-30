import {
  DialogContent,
  Typography,
  TextField,
  RadioGroup,
  FormControlLabel,
  Radio,
  Autocomplete,
  FormControl,
  MenuItem,
  OutlinedInput,
  Select,
} from '@mui/material';
import { makeStyles } from '@mui/styles';
import { DatePicker } from '@mui/x-date-pickers/DatePicker';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { useState } from 'react';

const useStyles = makeStyles({
  table: {
    display: 'table',
    borderSpacing: '6px',
    marginLeft: 'auto',
    marginRight: 'auto',
  },
  tableRow: {
    display: 'table-row',
    marginBottom: '1em',
  },
  tableCellText: {
    display: 'table-cell',
    verticalAlign: 'middle',
    textAlign: 'right',
  },
  tableCellContent: {
    display: 'table-cell',
    verticalAlign: 'middle',
  },
  datePicker: {
    height: '40px',
  },
  template: {
    paddingTop: '8px',
    display: 'table-cell',
    textAlign: 'right',
  },
});

const CreateScoutingReportForm = () => {
  const classes = useStyles();
  const [disabled, setDisabled] = useState(true);

  return (
    <DialogContent dividers>
      <div className={classes.table}>
        <div className={classes.tableRow}>
          <Typography className={classes.tableCellText}>
            Report Name:
          </Typography>
          <TextField
            autoFocus
            margin="normal"
            id="name"
            variant="outlined"
            size="small"
            className={classes.tableCellContent}
          />
        </div>
        <div className={classes.tableRow}>
          <Typography className={classes.tableCellText}>
            Opponent Team:
          </Typography>
          <RadioGroup row className={classes.tableCellContent}>
            <FormControlLabel value="D-I" control={<Radio />} label="D-I" />
            <FormControlLabel value="D-II" control={<Radio />} label="D-II" />
            <FormControlLabel value="D-III" control={<Radio />} label="D-III" />
          </RadioGroup>
        </div>
        <div className={classes.tableRow}>
          <div className={classes.tableCellText} />
          <Autocomplete
            className={classes.tableCellContent}
            id="combo-box-demo"
            options={schools}
            sx={{ width: '225px' }}
            size="small"
            renderInput={(params) => <TextField {...params} />}
          />
        </div>
        <div className={classes.tableRow}>
          <Typography className={classes.tableCellText}>Season:</Typography>
          <FormControl className={classes.tableCellContent}>
            <Select size="small" input={<OutlinedInput />} defaultValue={0}>
              <MenuItem value={0}>2022-2023</MenuItem>
              <MenuItem value={1}>2021-2022</MenuItem>
              <MenuItem value={2}>2020-2021</MenuItem>
              <MenuItem value={3}>2019-2020</MenuItem>
              <MenuItem value={4}>2018-2019</MenuItem>
              <MenuItem value={5}>2017-2018</MenuItem>
            </Select>
          </FormControl>
        </div>
        <div className={classes.tableRow}>
          <Typography className={classes.tableCellText}>Game Date:</Typography>
          <LocalizationProvider dateAdapter={AdapterDayjs}>
            <DatePicker sx={{ '>div': { height: '40px' } }} />
          </LocalizationProvider>
        </div>
        <div className={classes.tableRow}>
          <Typography className={classes.tableCellText}>
            Prepared By:
          </Typography>
          <FormControl className={classes.tableCellContent}>
            <Select size="small" input={<OutlinedInput />} defaultValue={0}>
              <MenuItem value={0}>Arturo Ormond</MenuItem>
              <MenuItem value={1}>Ben Beauchamp</MenuItem>
              <MenuItem value={2}>Blake Fernandez</MenuItem>
              <MenuItem value={3}>Dan Tappan</MenuItem>
              <MenuItem value={4}>David Riley</MenuItem>
              <MenuItem value={5}>Kolton Anderson</MenuItem>
            </Select>
          </FormControl>
        </div>
        <div className={classes.tableRow}>
          <Typography className={classes.template}>Template:</Typography>
          <div className={classes.tableCellContent}>
            <RadioGroup>
              <FormControlLabel
                value="Blank"
                control={<Radio onChange={() => setDisabled(true)} />}
                label="Blank Template"
              />
              <FormControlLabel
                value="Saved"
                control={<Radio onChange={() => setDisabled(false)} />}
                label="Saved Template"
              />
            </RadioGroup>
            <Autocomplete
              disabled={disabled}
              style={{ alignSelf: 'baseline' }}
              id="combo-box-demo"
              options={templates}
              sx={{ width: '225px' }}
              size="small"
              renderInput={(params) => <TextField {...params} />}
            />
          </div>
        </div>
      </div>
    </DialogContent>
  );
};

export default CreateScoutingReportForm;

const schools = [
  { label: 'Alabama', logo: 'Logo' },
  { label: 'Duke', logo: 'Logo' },
  { label: 'Uconn', logo: 'Logo' },
  { label: 'Baylor', logo: 'Logo' },
  { label: 'Gonzaga', logo: 'Logo' },
  { label: 'LSU', logo: 'Logo' },
  { label: 'BYU', logo: 'Logo' },
];

const templates = [
  { label: 'Template 1' },
  { label: 'Template 2' },
  { label: 'Template 3' },
  { label: 'Template 4' },
  { label: 'Template 5' },
  { label: 'Template 6' },
  { label: 'Template 7' },
];

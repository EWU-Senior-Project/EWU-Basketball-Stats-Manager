import {
  Menu,
  AcUnit,
  Image,
  GridOn,
  Person,
  BarChart,
  Apps,
} from '@mui/icons-material';
import type { CSSObject, Theme } from '@mui/material';
import {
  Drawer,
  List,
  ListItem,
  ListItemButton,
  ListItemText,
  ListItemIcon,
  styled,
} from '@mui/material';
import { useState } from 'react';
import SectionHeader from './PanelOptions/SectionHeader';
import type { ReactJSXElement } from '@emotion/react/types/jsx-namespace';
import Text from './PanelOptions/Text';

interface IProps {
  AddComponent: (item: ReactJSXElement) => void;
}

const drawerWidth = 220;

const openedMixin = (theme: Theme): CSSObject => ({
  width: drawerWidth,
  transition: theme.transitions.create('width', {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.enteringScreen,
  }),
  overflowX: 'hidden',
});

const closedMixin = (theme: Theme): CSSObject => ({
  transition: theme.transitions.create('width', {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.leavingScreen,
  }),
  overflowX: 'hidden',
  width: `calc(${theme.spacing(7)} + 1px)`,
  [theme.breakpoints.up('sm')]: {
    width: `calc(${theme.spacing(7)} + 1px)`,
  },
});

const StyledDrawer = styled(Drawer, {
  shouldForwardProp: (prop) => prop !== 'open',
})(({ theme, open }) => ({
  width: drawerWidth,
  height: '100%',
  flexShrink: 0,
  whiteSpace: 'nowrap',
  boxSizing: 'border-box',
  ...(open && {
    ...openedMixin(theme),
    '& .MuiDrawer-paper': openedMixin(theme),
  }),
  ...(!open && {
    ...closedMixin(theme),
    '& .MuiDrawer-paper': closedMixin(theme),
  }),
  borderRightStyle: 'solid',
  borderRightColor: 'lightgrey',
  borderRightWidth: 1,
}));

const ScoutingReportPanel = ({ AddComponent }: IProps) => {
  const [isExpanded, setCollapsed] = useState(true);

  return (
    <StyledDrawer
      variant="permanent"
      style={{ position: 'sticky' }}
      open={isExpanded}
      sx={{
        '& .MuiDrawer-root': {
          position: 'relative',
        },
        '& .MuiPaper-root': {
          position: 'relative',
        },
      }}
    >
      <List sx={{ padding: 0 }}>
        <ListItem disablePadding>
          <ListItemButton onClick={() => setCollapsed(!isExpanded)}>
            <ListItemIcon>
              <Menu fontSize="small" />
            </ListItemIcon>
            <ListItemText primaryTypographyProps={{ fontSize: 12 }}>
              Title
            </ListItemText>
          </ListItemButton>
        </ListItem>
        {listItems.map((item) => (
          <ListItem disablePadding key={item.title}>
            <ListItemButton onClick={() => AddComponent(item.component)}>
              <ListItemIcon>{item.icon}</ListItemIcon>
              <ListItemText primaryTypographyProps={{ fontSize: 12 }}>
                {item.title}
              </ListItemText>
            </ListItemButton>
          </ListItem>
        ))}
      </List>
    </StyledDrawer>
  );
};

export default ScoutingReportPanel;

interface IListItem {
  title: string;
  icon: JSX.Element;
  component?: any;
}

const listItems: IListItem[] = [
  {
    title: 'Section Header',
    icon: <AcUnit fontSize="small" />,
    component: <SectionHeader />,
  },
  {
    title: 'Spacer',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Text',
    icon: <AcUnit fontSize="small" />,
    component: <Text />,
  },
  {
    title: 'Image',
    icon: <Image fontSize="small" />,
  },
  {
    title: 'Team Stats',
    icon: <GridOn fontSize="small" />,
  },
  {
    title: 'Personnel',
    icon: <Person fontSize="small" />,
  },
  {
    title: 'Leaders',
    icon: <BarChart fontSize="small" />,
  },
  {
    title: 'Recent Games',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Depth Chart',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Custom Table',
    icon: <Apps fontSize="small" />,
  },
  {
    title: 'Team Advanced Stats',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Clutch Stats',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Lineup Stats',
    icon: <GridOn fontSize="small" />,
  },
  {
    title: 'Shot Charts',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Synergy Stats',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Plays',
    icon: <AcUnit fontSize="small" />,
  },
  {
    title: 'Saved Tiles',
    icon: <AcUnit fontSize="small" />,
  },
];

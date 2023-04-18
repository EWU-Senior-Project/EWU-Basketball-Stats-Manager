import { Button } from '@mui/material';
import { Link, useMatches } from '@remix-run/react';
import { useState } from 'react';
import type { IButton } from '~/interfaces/IButton';

const ButtonList = (props: { buttons: IButton[] }) => {
  const { buttons } = props;
  const matches = useMatches();
  const [selected, setSelected] = useState(matches[2].pathname.split('/')[2]);

  return (
    <>
      {buttons.map((button) => (
        <Link
          style={{ textDecoration: 'none' }}
          to={button.to}
          key={button.name}
        >
          <Button
            sx={{ padding: '0em .5em' }}
            onClick={() => setSelected(button.to)}
            color="info"
            key={button.name}
            variant={selected === button.to ? 'contained' : void 0}
          >
            {button.name}
          </Button>
        </Link>
      ))}
    </>
  );
};

export default ButtonList;

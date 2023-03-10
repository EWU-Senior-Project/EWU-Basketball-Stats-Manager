import { Button } from '@mui/material';
import { Link } from '@remix-run/react';
import { useState } from 'react';
import type { IButton } from '~/interfaces/IButton';

const ButtonList = (props: { buttons: IButton[] }) => {
  const { buttons } = props;
  const [selected, setSelected] = useState(buttons[0].name);
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
            onClick={() => setSelected(button.name)}
            color="info"
            key={button.name}
            variant={selected === button.name ? 'contained' : void 0}
          >
            {button.name}
          </Button>
        </Link>
      ))}
    </>
  );
};

export default ButtonList;

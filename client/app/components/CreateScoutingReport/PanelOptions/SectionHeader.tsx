import { Card } from '@mui/material';

import SlateEditor from '~/components/SlateEditor';

const SectionHeader = () => {
  return (
    <Card
      variant="outlined"
      style={{ display: 'flex', flex: 1, height: '50px' }}
    >
      <SlateEditor />
    </Card>
  );
};

export default SectionHeader;

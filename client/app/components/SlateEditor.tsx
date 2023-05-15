import { useCallback, useState } from 'react';
import { createEditor } from 'slate';
import type { Descendant } from 'slate';
import { Editable, Slate, withReact } from 'slate-react';
import type { BaseEditor } from 'slate';
import type { ReactEditor } from 'slate-react';
import { Typography } from '@mui/material';
import theme from '~/styles/pallette';

type CustomElement = { type: 'paragraph'; children: CustomText[] };
type CustomText = { text: string };

type IProps = {
  type: 'header' | 'text' | 'description';
};

declare module 'slate' {
  interface CustomTypes {
    Editor: BaseEditor & ReactEditor;
    Element: CustomElement;
    Text: CustomText;
  }
}

const initialValue: Descendant[] = [
  {
    type: 'paragraph',
    children: [{ text: 'Default Text' }],
  },
];

const Header = (props: any) => {
  return (
    <Typography
      variant="h4"
      style={{ textAlign: 'center' }}
      {...props.attributes}
    >
      {props.children}
    </Typography>
  );
};

const Description = (props: any) => {
  return <Typography {...props.attributes}>{props.children}</Typography>;
};

const Text = (props: any) => {
  return (
    <div>
      <Typography
        variant="h5"
        style={{
          clipPath: 'polygon(0% 0%, 100% 0%, 0% 1000%, 0% 0%)',
          background: theme.palette.primary.main,
          textAlign: 'left',
          padding: '6px 0 6px 6px',
        }}
        {...props.attributes}
      >
        {props.children}
      </Typography>
    </div>
  );
};

const DefaultElement = (props: any) => {
  return <p {...props.attributes}>{props.children}</p>;
};

const SlateEditor = ({ type }: IProps) => {
  const [editor] = useState(() => withReact(createEditor()));

  const renderElement = useCallback((props: any) => {
    switch (type) {
      case 'header':
        return <Header {...props} />;
      case 'description':
        return <Description {...props} />;
      case 'text':
        return <Text {...props} />;
      default:
        return <DefaultElement {...props} />;
    }
  }, []);

  return (
    <Slate editor={editor} value={initialValue}>
      <Editable renderElement={renderElement} />
    </Slate>
  );
};
export default SlateEditor;

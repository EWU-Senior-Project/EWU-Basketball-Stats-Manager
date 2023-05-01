import { useState } from 'react';
import { createEditor } from 'slate';
import { Editable, Slate, withReact } from 'slate-react';
import type { BaseEditor } from 'slate';
import type { ReactEditor } from 'slate-react';

type CustomElement = { type: 'paragraph'; children: CustomText[] };
type CustomText = { text: string };

declare module 'slate' {
  interface CustomTypes {
    Editor: BaseEditor & ReactEditor;
    Element: CustomElement;
    Text: CustomText;
  }
}

const initialValue = [
  {
    type: 'paragraph',
    children: [{ text: 'A line of text in a paragraph.' }],
  },
];

const SlateEditor = () => {
  const [editor] = useState(() => withReact(createEditor()));
  // Render the Slate context.
  return (
    <Slate editor={editor} value={initialValue}>
      <Editable />
    </Slate>
  );
};
export default SlateEditor;

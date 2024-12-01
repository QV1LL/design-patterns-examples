using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoImplementation
{
    internal class Editor
    {
        private string _text;
        public string Text
        {
            set
            {
                if (value != null)
                    this._text = value;
            }
            get { return _text; }
        }

        private int _cursorX;
        public int CursorX
        {
            set { this._cursorX = value; }
            get { return _cursorX; }
        }

        private int _cursorY;
        public int CursorY
        {
            set { this._cursorY = value; }
            get { return _cursorY; }
        }

        private int _screenScroll;
        public int ScreenScroll
        {
            set { this._screenScroll = value; }
            get { return _screenScroll; }
        }

        public EditorMemento CreateBackup()
        {
            return new EditorMemento(this);
        }

        public override string ToString()
        {
            return "Text: " + this.Text + "\n"
                + "Cursor position: " + this.CursorX + " " + this.CursorY + "\n"
                + "Screen scroll: " + this.ScreenScroll + "\n\n";
        }
    }
}

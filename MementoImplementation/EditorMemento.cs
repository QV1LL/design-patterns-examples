using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoImplementation
{
    internal class EditorMemento : IMemento
    {
        private Editor _editor;

        private string _text;
        private int _cursorX;
        private int _cursorY;
        private int _screenScroll;

        public EditorMemento(Editor editor)
        {
            this._editor = editor;
            this._text = editor.Text;
            this._cursorX = editor.CursorX;
            this._cursorY = editor.CursorY;
            this._screenScroll = editor.ScreenScroll;
        }

        public void Restore()
        {
            this._editor.Text = this._text;
            this._editor.CursorX = this._cursorX;
            this._editor.CursorY = this._cursorY;
            this._editor.ScreenScroll = this._screenScroll;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandImplementation
{
    internal class DeleteCommand : ICommand
    {
        private readonly TextEditor _textEditor;
        private readonly int _length;
        private string _backup;

        public DeleteCommand(TextEditor textEditor, int _lenght)
        {
            this._textEditor = textEditor;
            this._length = _lenght;
            this._backup = string.Empty;
        }

        public void Execute()
        {
            this._backup = this._textEditor.Text.Substring(
                this._textEditor.Text.Length - this._length,
                this._length);

            this._textEditor.RemoveText(this._length);
        }

        public void Unexecute()
        {
            this._textEditor.AppendText(this._backup);
        }
    }

}

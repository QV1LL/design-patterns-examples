using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandImplementation
{
    internal class AppendCommand : ICommand
    {
        private readonly TextEditor _textEditor;
        private readonly string _textToAppend;

        public AppendCommand(TextEditor textEditor, string textToAppend)
        {
            _textEditor = textEditor;
            _textToAppend = textToAppend;
        }

        public void Execute()
        {
            _textEditor.AppendText(_textToAppend);
        }

        public void Unexecute()
        {
            _textEditor.RemoveText(_textToAppend.Length);
        }
    }

}

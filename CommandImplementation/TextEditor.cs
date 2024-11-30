using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandImplementation
{
    internal class TextEditor
    {
        private string _text = string.Empty;

        public string Text => _text;

        public void AppendText(string newText)
        {
            _text += newText;
        }

        public void RemoveText(int length)
        {
            if (length > 0 && length <= _text.Length)
                _text = _text.Substring(0, _text.Length - length);
        }
    }

}

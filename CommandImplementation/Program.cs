using System;

namespace CommandImplementation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var textEditor = new TextEditor();
            var commandManager = new CommandManager();

            var appendHello = new AppendCommand(textEditor, "Hello");
            commandManager.ExecuteCommand(appendHello);
            Console.WriteLine($"Text after 'Hello': {textEditor.Text}");

            var deleteHello = new DeleteCommand(textEditor, 4);
            commandManager.ExecuteCommand(deleteHello);
            Console.WriteLine($"Text after delete 4 chars: {textEditor.Text}");

            commandManager.Undo();
            Console.WriteLine($"Text after Undo: {textEditor.Text}");

            commandManager.Redo();
            Console.WriteLine($"Text after Redo: {textEditor.Text}");
        }
    }

}
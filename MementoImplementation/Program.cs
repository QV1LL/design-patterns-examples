using System;

namespace MementoImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var backups = new Stack<IMemento>();

            Editor editor = new Editor();
            editor.Text = "Hello";
            editor.ScreenScroll = 800;
            editor.CursorX = 200;
            editor.CursorY = 100;
            backups.Push(editor.CreateBackup());

            Console.WriteLine(editor);

            editor.Text = "Hello world!";
            backups.Push(editor.CreateBackup());

            Console.WriteLine(editor);

            editor.CursorX += 100;
            backups.Push(editor.CreateBackup());

            Console.WriteLine(editor);

            while (backups.Count > 0)
            {
                backups.Pop().Restore();
                Console.WriteLine("State restored!\n" + editor);
            }
        }
    }
}
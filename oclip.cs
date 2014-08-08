using System;
using System.Windows;
namespace oclip
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine(Clipboard.GetText());
        }
    }
}

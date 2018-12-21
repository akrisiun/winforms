using System;
using System.Windows.Forms;

namespace FormsBrowser
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var form = new Form1();

            Application.Run(form);
        }
    }
}

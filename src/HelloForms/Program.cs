using System;
using System.Windows.Forms;

namespace HelloForms
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World WinForms!");

            var form = new Form1();

            Application.Run(form);
        }
    }
}

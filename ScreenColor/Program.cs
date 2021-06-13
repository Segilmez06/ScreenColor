using System;
using System.Diagnostics;

namespace ScreenColor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Process list = new Process();
            list.StartInfo.FileName = "xrandr";
            list.StartInfo.Arguments = "--listmonitors";

            Process change = new Process();
            change.StartInfo.FileName = "xrandr";

            string selectedMon;
            string selectedBri;

            Console.WriteLine("================");
            Console.WriteLine("ScreenColor v1.0");
            Console.WriteLine("================");
            Console.WriteLine();

            list.Start();
            list.WaitForExit();
            Console.WriteLine();

            Console.Write("Selected Monitor:");
            selectedMon = Console.ReadLine();

            Console.Write("Selected Brightness(Between 0.0 - 1.0):");
            selectedBri = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Changing...");
            change.StartInfo.Arguments = "--output " + selectedMon + " --brightness " + selectedBri;
            change.Start();
            change.WaitForExit();
            Console.WriteLine("Changed.");
            Console.WriteLine();

            Console.Write("Press any key to exit...");
            Console.Read();
        }
    }
}

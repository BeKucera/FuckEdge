using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace FuckEdge
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {
            ShowWindow(GetConsoleWindow(),SW_HIDE);
            if (args.Length == 0)
            {
                Process.Start("chrome.exe");
                Environment.Exit(0);
            }

            string start = "search%3Fq%3D";
            string end = "%26form%3D";

            if (!args[1].Contains(start))
            {
                start = "microsoft-edge:https://www.bing.";
                string adresa = args[1].Substring(args[1].IndexOf(start)+start.Length);
                Process.Start("https://google."+adresa);
                
            }


            string address = args[1].Substring(args[1].IndexOf(start) + start.Length);
            address = address.Remove(address.IndexOf(end));
            address = $"https://www.google.com/search?q={address}";
            Process.Start(address);
        }
    }
}

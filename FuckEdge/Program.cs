using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckEdge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Process.Start("chrome.exe");
                Environment.Exit(0);
            }
            string start = "search%3Fq%3D";
            string end = "%26form%3D";
            string address = args[1].Substring(args[1].IndexOf(start) + start.Length);
            address = address.Remove(address.IndexOf(end));
            address = address.Replace("+"," ").Replace("%2B", " ");
            address = $"https://www.google.com/search?q={address}";
            Process.Start(address );
        }
    }
}

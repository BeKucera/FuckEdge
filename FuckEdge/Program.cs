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
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj");

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

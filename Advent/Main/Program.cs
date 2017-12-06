using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;
using System.Net;
using System.IO;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = File.ReadLines("Input/Dec6.txt").ToArray();
            Dec6obj today = new Dec6obj(a);
            Console.WriteLine(today.CountLoopLength());
        }
    }
}

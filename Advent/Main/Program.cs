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
            string[] a = File.ReadLines("Input/Dec7.txt").ToArray();
            string head = Dec7.FindHead(a);
            TreeCreator builder = new TreeCreator(a, head);
            Console.WriteLine(builder.FindOffWeight());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[]
            { 626, 2424, 2593, 139, 2136, 163, 1689, 367, 2235, 125, 2365, 924, 135, 2583, 1425, 2502 };
            int[] a2 = new int[]
            { 183, 149, 3794, 5221, 5520, 162, 5430, 4395, 2466, 1888, 3999, 3595, 195, 181, 6188, 4863 };
            int[] a3 = new int[]
            { 163, 195, 512, 309, 102, 175, 343, 134, 401, 372, 368, 321, 350, 354, 183, 490 };
            int[] a4 = new int[]
            { 2441, 228, 250, 2710, 200, 1166, 231, 2772, 1473, 2898, 2528, 2719, 1736, 249, 1796, 903 };
            int[] a5 = new int[]
            { 3999, 820, 3277, 3322, 2997, 1219, 1014, 170, 179, 2413, 183, 3759, 3585, 2136, 3700, 188 };
            int[] a6 = new int[]
            { 132, 108, 262, 203, 228, 104, 205, 126, 69, 208, 235, 311, 313, 258, 110, 117 };
            int[] a7 = new int[]
            { 963, 1112, 1106, 50, 186, 45, 154, 60, 1288, 1150, 986, 232, 872, 433, 48, 319 };
            int[] a8 = new int[]
            { 111, 1459, 98, 1624, 2234, 2528, 93, 1182, 97, 583, 2813, 3139, 1792, 1512, 1326, 3227 };
            int[] a9 = new int[]
            { 371, 374, 459, 83, 407, 460, 59, 40, 42, 90, 74, 163, 494, 250, 488, 444 };
            int[] a10 = new int[]
            { 1405, 2497, 2079, 2350, 747, 1792, 2412, 2615, 89, 2332, 1363, 102, 81, 2346, 122, 1356 };
            int[] a11 = new int[]
            { 1496, 2782, 2257, 2258, 961, 214, 219, 2998, 400, 230, 2676, 3003, 2955, 254, 2250, 2707 };
            int[] a12 = new int[]
            { 694, 669, 951, 455, 2752, 216, 1576, 3336, 251, 236, 222, 2967, 3131, 3456, 1586, 1509 };
            int[] a13 = new int[]
            { 170, 2453, 1707, 2017, 2230, 157, 2798, 225, 1891, 945, 943, 2746, 186, 206, 2678, 2156 };
            int[] a14 = new int[]
            { 3632, 3786, 125, 2650, 1765, 1129, 3675, 3445, 1812, 3206, 99, 105, 1922, 112, 1136, 3242 };
            int[] a15 = new int[]
            { 6070, 6670, 1885, 1994, 178, 230, 5857, 241, 253, 5972, 7219, 252, 806, 6116, 4425, 3944 };
            int[] a16 = new int[]
            { 2257, 155, 734, 228, 204, 2180, 175, 2277, 180, 2275, 2239, 2331, 2278, 1763, 112, 2054 };
            Array[] arr = new Array[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16 };
            Console.WriteLine(Dec2.CheckSumDiv(arr));
        }
    }
}

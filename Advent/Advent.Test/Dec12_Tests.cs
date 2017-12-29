using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Advent.Test
{
    [TestFixture]
    public class Dec12_Tests
    {
        [Test]
        public void Test1A()
        {
            string[] a = new string[]
            {
                "0 <-> 2",
                "1 <-> 1",
                "2 <-> 0, 3, 4",
                "3 <-> 2, 4",
                "4 <-> 2, 3, 6",
                "5 <-> 6",
                "6 <-> 4, 5"
            };
            Assert.AreEqual(6, Dec12.CountInGroup(a, 0));
        }

        [Test]
        public void Test1B()
        {
            string[] a = new string[]
            {
                "0 <-> 2",
                "1 <-> 1",
                "5 <-> 6",
                "6 <-> 4, 5",
                "2 <-> 0, 3, 4",
                "3 <-> 2, 4",
                "4 <-> 2, 3, 6"                
            };
            Assert.AreEqual(6, Dec12.CountInGroup(a, 0));
        }

        [Test]
        public void Test1C()
        {
            string[] a = new string[]
            {
                "0 <-> 1",
                "1 <-> 2",
                "2 <-> 3",
                "4 <-> 5",
                "6 <-> 5",
                "3 <-> 4",
            };
            Assert.AreEqual(7, Dec12.CountInGroup(a, 0));
        }

        [Test]
        public void Test1D()
        {
            string[] a = new string[]
            {
                "0 <-> 1, 2, 3, 4, 5, 6, 7, 8, 9",
            };
            Assert.AreEqual(10, Dec12.CountInGroup(a, 0));
        }

        /*
        [Test]
        public void Test1E()
        {
            string[] a = File.ReadLines("Input/Dec12.txt").ToArray();
            Assert.AreEqual(288, Dec12.CountInGroup(a, 0));
        }
        */

        [Test]
        public void Test2A()
        {
            string[] a = new string[]
            {
                "0 <-> 2",
                "1 <-> 1",
                "2 <-> 0, 3, 4",
                "3 <-> 2, 4",
                "4 <-> 2, 3, 6",
                "5 <-> 6",
                "6 <-> 4, 5"
            };
            Assert.AreEqual(2, Dec12.CountGroups(a));
        }

        [Test]
        public void Test2B()
        {
            string[] a = new string[]
            {
                "0 <-> 2",
                "1 <-> 1",
                "5 <-> 6",
                "6 <-> 4, 5",
                "2 <-> 0, 3, 4",
                "3 <-> 2, 4",
                "4 <-> 2, 3, 6"
            };
            Assert.AreEqual(2, Dec12.CountGroups(a));
        }

        [Test]
        public void Test2C()
        {
            string[] a = new string[]
            {
                "0 <-> 1",
                "1 <-> 2",
                "2 <-> 3",
                "4 <-> 5",
                "6 <-> 5",
                "3 <-> 4",
            };
            Assert.AreEqual(1, Dec12.CountGroups(a));
        }

        [Test]
        public void Test2D()
        {
            string[] a = new string[]
            {
                "0 <-> 1, 2, 3, 4, 5, 6, 7, 8, 9",
            };
            Assert.AreEqual(1, Dec12.CountGroups(a));
        }

        /*
        [Test]
        public void Test2E()
        {
            string[] a = File.ReadLines("Input/Dec12.txt").ToArray();
            Assert.AreEqual(211, Dec12.CountGroups(a));
        }
        */
    }
}

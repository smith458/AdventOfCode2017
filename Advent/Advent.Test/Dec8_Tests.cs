using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Advent;

namespace Advent.Test
{
    [TestFixture]
    public class Dec8_Tests
    {
        [Test]
        public void Test1A()
        {
            string[] a = new string[]
            {
                "a inc 5 if a == 0"
            };
            Assert.AreEqual(5, Dec8.ProcessInstructions(a));
        }

        [Test]
        public void Test1B()
        {
            string[] a = new string[]
            {
                "a inc -5 if a < 5"
            };
            Assert.AreEqual(-5, Dec8.ProcessInstructions(a));
        }

        [Test]
        public void Test1C()
        {
            string[] a = new string[]
            {
                "a inc 5 if a > 0"
            };
            Assert.AreEqual(0, Dec8.ProcessInstructions(a));
        }

        [Test]
        public void Test1D()
        {
            string[] a = new string[]
            {
                "a inc 5 if b == 0",
                "a dec 5 if b >= 0"
            };
            Assert.AreEqual(0, Dec8.ProcessInstructions(a));
        }

        /*
        [Test]
        public void Test1E()
        {
            string[] a = File.ReadLines("Input/Dec8.txt").ToArray();
            Assert.AreEqual(5752, Dec8.ProcessInstructions(a));
        }
        */

        [Test]
        public void Test2A()
        {
            string[] a = new string[]
            {
                "a inc 5 if a == 0"
            };
            Assert.AreEqual(5, Dec8.MaxDuringProcessInstructions(a));
        }

        [Test]
        public void Test2B()
        {
            string[] a = new string[]
            {
                "a inc -5 if a < 5"
            };
            Assert.AreEqual(0, Dec8.MaxDuringProcessInstructions(a));
        }

        [Test]
        public void Test2C()
        {
            string[] a = new string[]
            {
                "a inc 5 if a > 0"
            };
            Assert.AreEqual(0, Dec8.MaxDuringProcessInstructions(a));
        }

        [Test]
        public void Test2D()
        {
            string[] a = new string[]
            {
                "a inc 5 if b == 0",
                "a dec 5 if b >= 0"
            };
            Assert.AreEqual(5, Dec8.MaxDuringProcessInstructions(a));
        }

        /*
        [Test]
        public void Test2E()
        {
            string[] a = File.ReadLines("Input/Dec8.txt").ToArray();
            Assert.AreEqual(6366, Dec8.MaxDuringProcessInstructions(a));
        }
        */
    }
}

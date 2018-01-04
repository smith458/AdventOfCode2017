using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Advent.Test
{
    [TestFixture]
    public class Dec13_Test
    {
        [Test]
        public void Test1A()
        {
            string[] a = new string[]
            {
                "0: 3",
                "1: 2",
                "4: 4",
                "6: 4"
            };
            Assert.AreEqual(24, Dec13.CountSeverity(a));
        }

        /*
        [Test]
        public void Test1B()
        {
            string[] a = File.ReadLines("Input/Dec13.txt").ToArray();
            Assert.AreEqual(1624, Dec13.CountSeverity(a));
        }
        */

        [Test]
        public void Test2A()
        {
            string[] a = new string[]
            {
                "0: 3",
                "1: 2",
                "4: 4",
                "6: 4"
            };
            Assert.AreEqual(10, Dec13.CalculateDelay(a));
        }

        /*
        [Test]
        public void Test2B()
        {
            string[] a = File.ReadLines("Input/Dec13.txt").ToArray();
            Assert.AreEqual(3923436, Dec13.CalculateDelay(a));
        }
        */
    }
}

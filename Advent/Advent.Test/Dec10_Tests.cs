using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Advent.Test
{
    [TestFixture]
    public class Dec10_Tests
    {
        [Test]
        public void Test1A()
        {
            int len = 5;
            int[] input = new int[] { 3, 4, 1, 5 };
            Assert.AreEqual(12, Dec10.KnotHashCheck(len, input));
        }

        [Test]
        public void Test1B()
        {
            int len = 256;
            int[] input = new int[] { 97, 167, 54, 178, 2, 11, 209, 174, 119, 248, 254, 0, 255, 1, 64, 190 }; ;
            Assert.AreEqual(8536, Dec10.KnotHashCheck(len, input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Advent;

namespace Advent.Test
{
    public class Dec3_Tests
    {
        [Test]
        public void Test1A()
        {
            int a = 1;
            Assert.AreEqual(0, Dec3.FindSteps(a));
        }

        [Test]
        public void Test1B()
        {
            int a = 12;
            Assert.AreEqual(3, Dec3.FindSteps(a));
        }

        [Test]
        public void Test1C()
        {
            int a = 23;
            Assert.AreEqual(2, Dec3.FindSteps(a));
        }

        [Test]
        public void Test1D()
        {
            int a = 1024;
            Assert.AreEqual(31, Dec3.FindSteps(a));
        }

        [Test]
        public void Test1E()
        {
            int a = 361527;
            Assert.AreEqual(326, Dec3.FindSteps(a));
        }
    }
}

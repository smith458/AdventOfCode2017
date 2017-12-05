using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Advent;
using System.IO;

namespace Advent.Test
{

    public class Dec4_Tests
    {
        [Test]
        public void Test1A()
        {
            string[] a = new string[] { "aa bb cc dd ee" };
            Assert.AreEqual(1, Dec4.CountLegalPass(a));
        }

        [Test]
        public void Test1B()
        {
            string[] a = new string[] { "aa bb cc dd aa" };
            Assert.AreEqual(0, Dec4.CountLegalPass(a));
        }

        [Test]
        public void Test1C()
        {
            string[] a = new string[] { "aa bb cc dd aaa" };
            Assert.AreEqual(1, Dec4.CountLegalPass(a));
        }

        [Test]
        public void Test1D()
        {
            string[] a = new string[] { "aa bb cc dd ee", "ff gg hh ii jj" };
            Assert.AreEqual(2, Dec4.CountLegalPass(a));
        }

        [Test]
        public void Test1E()
        {
            string[] a = new string[] { "aa bb cc dd ee", "ff gg aa bb aaa aa" };
            Assert.AreEqual(1, Dec4.CountLegalPass(a));
        }

        /*
        [Test]
        public void Test1F()
        {
            string[] a = File.ReadLines("Input/Day4.txt").ToArray();
            Assert.AreEqual(477, Dec4.CountLegalPass(a));
        } 
        */
    }
}

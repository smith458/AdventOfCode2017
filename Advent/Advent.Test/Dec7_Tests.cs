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
    public class Dec7_Tests
    {
        [Test]
        public void Test1A()
        {
            string[] a = new string[] { "a (1)" };
            Assert.AreEqual("a", Dec7.FindHead(a));
        }

        [Test]
        public void Test1B()
        {
            string[] a = new string[] { "a (1) -> b", "b (2)" };
            Assert.AreEqual("a", Dec7.FindHead(a));
        }

        [Test]
        public void Test1C()
        {
            string[] a = new string[] { "a (1) -> b" , "b (3)", "c (1) -> a" };
            Assert.AreEqual("c", Dec7.FindHead(a));
        }

        [Test]
        public void Test1D()
        {
            string[] a = new string[] { "a (1) -> b, c, d", "b (3)", "c (3)", "d (3)" };
            Assert.AreEqual("a", Dec7.FindHead(a));
        }

        /*
        [Test]
        public void Test1E()
        {
            string[] a = File.ReadLines("Input/Dec5.txt").ToArray();
            Assert.AreEqual(veboyvy, Dec7.FindHead(a));
        } 
        */
    }
}

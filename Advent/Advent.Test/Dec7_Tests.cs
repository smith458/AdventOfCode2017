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

        [Test]
        public void Test2A()
        {
            string[] a = new string[] { "a (1) -> b, c, d", "b (2)", "c (2)", "d (3)" };
            string head = Dec7.FindHead(a);
            TreeCreator builder = new TreeCreator(a, head);
            Assert.AreEqual(2, builder.FindOffWeight());
        }

        [Test]
        public void Test2B()
        {
            string[] a = new string[] { "a (1) -> b, c", "b (3) -> d, e, f", "c (5)", "d (1)", "e (1)", "f (1)" };
            string head = Dec7.FindHead(a);
            TreeCreator builder = new TreeCreator(a, head);
            Assert.AreEqual(6, builder.FindOffWeight());
        }

        [Test]
        public void Test2C()
        {
            string[] a = new string[] {
                "pare (1) -> ugml, padx, fwft",
                "ugml (68) -> gyxo, ebii, jptl",
                "padx (45) -> pbga, havc, qoyq",
                "fwft (72) -> ktlj, cntj, xhth",
                "gyxo (61)",
                "ebii (61)",
                "jptl (61)",
                "pbga (66)",
                "havc (66)",
                "qoyq (66)",
                "ktlj (57)",
                "cntj (57)",
                "xhth (57)"
            };
            string head = Dec7.FindHead(a);
            TreeCreator builder = new TreeCreator(a, head);
            Assert.AreEqual(60, builder.FindOffWeight());
        }

        /*
        [Test]
        public void Test2D()
        {
            string[] a = File.ReadLines("Input/Dec5.txt").ToArray();
            string head = Dec7.FindHead(a);
            TreeCreator builder = new TreeCreator(a, head);
            Assert.AreEqual(17561, builder.FindOffWeight());
        } 
        */
    }
}

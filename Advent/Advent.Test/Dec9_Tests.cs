using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Advent.Test
{
    [TestFixture]
    public class Dec9_Test
    {
        [Test]
        public void Test1A()
        {
            string a = "{}";
            Assert.AreEqual(1, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1B()
        {
            string a = "{{{}}}";
            Assert.AreEqual(6, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1C()
        {
            string a = "{{},{}}";
            Assert.AreEqual(5, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1D()
        {
            string a = "{{{},{},{{}}}}";
            Assert.AreEqual(16, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1E()
        {
            string a = "{<a>,<a>,<a>,<a>}";
            Assert.AreEqual(1, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1F()
        {
            string a = "{{<ab>},{<ab>},{<ab>},{<ab>}}";
            Assert.AreEqual(9, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1G()
        {
            string a = "{{<!!>},{<!!>},{<!!>},{<!!>}}";
            Assert.AreEqual(9, Dec9.ScoreGroups(a));
        }

        [Test]
        public void Test1H()
        {
            string a = "{{<a!>},{<a!>},{<a!>},{<ab>}}";
            Assert.AreEqual(3, Dec9.ScoreGroups(a));
        }

        /*
        [Test]
        public void Test1H()
        {
            string[] a = File.ReadLines("Input/Dec9.txt").ToArray();
            Assert.AreEqual(17537, Dec9.ScoreGroups(a[0]));
        }
        */

        [Test]
        public void Test2A()
        {
            string a = "<>";
            Assert.AreEqual(0, Dec9.CountCancelled(a));
        }

        [Test]
        public void Test2B()
        {
            string a = "<random characters>";
            Assert.AreEqual(17, Dec9.CountCancelled(a));
        }

        [Test]
        public void Test2C()
        {
            string a = "<<<<>";
            Assert.AreEqual(3, Dec9.CountCancelled(a));
        }

        [Test]
        public void Test2D()
        {
            string a = "<{!>}>";
            Assert.AreEqual(2, Dec9.CountCancelled(a));
        }

        [Test]
        public void Test2E()
        {
            string a = "<!!>";
            Assert.AreEqual(0, Dec9.CountCancelled(a));
        }

        [Test]
        public void Test2F()
        {
            string a = "<!!!>>";
            Assert.AreEqual(0, Dec9.CountCancelled(a));
        }

        [Test]
        public void Test2G()
        {
            string a = "<{o\"i!a,<{i<a>";
            Assert.AreEqual(10, Dec9.CountCancelled(a));
        }

        /*
        [Test]
        public void Test1H()
        {
            string[] a = File.ReadLines("Input/Dec9.txt").ToArray();
            Assert.AreEqual(7539, Dec9.CountCancelled(a[0]));
        }
        */
    }
}
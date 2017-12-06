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
    public class Dec6_Tests
    {
        [Test]
        public void Test1A()
        {
            Dec6obj a = new Dec6obj( new int[] { 1 });
            Assert.AreEqual(1, a.CountReallocations());
        }

        [Test]
        public void Test1B()
        {
            Dec6obj a = new Dec6obj(new int[] { 1, 1 });
            Assert.AreEqual(2, a.CountReallocations());
        }

        [Test]
        public void Test1C()
        {
            Dec6obj a = new Dec6obj(new int[] { 3, 0 });
            Assert.AreEqual(3, a.CountReallocations());
        }

        [Test]
        public void Test1D()
        {
            Dec6obj a = new Dec6obj(new int[] { 4,1,15,12,0,9,9,5,5,8,7,3,14,5,12,3 });
            Assert.AreEqual(6681, a.CountReallocations());
        }

        
    }
}

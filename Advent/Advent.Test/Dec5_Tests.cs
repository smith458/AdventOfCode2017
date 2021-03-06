﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Advent;

namespace Advent.Test
{
    [TestFixture]
    public class Dec5_Test
    {
        [Test]
        public void Test1A()
        {
            int[] a = new int[] { 1 };
            Assert.AreEqual(1, Dec5.CountArraySteps(a));
        }

        [Test]
        public void Test1B()
        {
            int[] a = new int[] { 1, 1, 1, 1, 1 };
            Assert.AreEqual(5, Dec5.CountArraySteps(a));
        }

        [Test]
        public void Test1C()
        {
            int[] a = new int[] { 1, 2, 1, 2, 1 };
            Assert.AreEqual(3, Dec5.CountArraySteps(a));
        }

        [Test]
        public void Test1D()
        {
            int[] a = new int[] { 1, -1 };
            Assert.AreEqual(3, Dec5.CountArraySteps(a));
        }

        [Test]
        public void Test1E()
        {
            int[] a = new int[] { 1, -1, -2, -3, -4 };
            Assert.AreEqual(9, Dec5.CountArraySteps(a));
        }

        /*
        [Test]
        public void Test1F()
        {
            string[] a = File.ReadLines("Input/Dec5.txt").ToArray();
           Assert.AreEqual(343364, Dec5.CountArraySteps(a));
        } 
        */

        [Test]
        public void Test2A()
        {
            int[] a = new int[] { 1 };
            Assert.AreEqual(1, Dec5.CountArrayStrangeSteps(a));
        }

        [Test]
        public void Test2B()
        {
            int[] a = new int[] { 1, 1, 1, 1, 1 };
            Assert.AreEqual(5, Dec5.CountArrayStrangeSteps(a));
        }

        [Test]
        public void Test2C()
        {
            int[] a = new int[] { 1, 2, 1, 2, 1 };
            Assert.AreEqual(3, Dec5.CountArrayStrangeSteps(a));
        }

        [Test]
        public void Test2D()
        {
            int[] a = new int[] { 1, -1 };
            Assert.AreEqual(3, Dec5.CountArrayStrangeSteps(a));
        }

        [Test]
        public void Test2E()
        {
            int[] a = new int[] { 1, -1, -2, -3, -4 };
            Assert.AreEqual(24, Dec5.CountArrayStrangeSteps(a));
        }

        /*
        [Test]
        public void Test1F()
        {
            string[] a = File.ReadLines("Input/Dec5.txt").ToArray();
           Assert.AreEqual(25071947, Dec5.CountArrayStrangeSteps(a));
        } 
        */
    }
}

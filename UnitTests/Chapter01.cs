﻿using Chapter01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Chapter01
    {
        [TestMethod]
        public void Q01TestValidUniques()
        {
            var q = new Q01_1();
            Assert.IsTrue(q.IsUniqueAscii("abc"));
            Assert.IsTrue(q.IsUniqueAscii(""));
        }

        [TestMethod]
        public void Q01TestInvalidUniques()
        {
            var q = new Q01_1();
            Assert.IsFalse(q.IsUniqueAscii("aa"));
            Assert.IsFalse(q.IsUniqueAscii("abcdefghijklmnopqrstuvwxyza"));
        }
    }
}
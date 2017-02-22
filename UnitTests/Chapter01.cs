using Chapter01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Chapter01
    {
        [TestMethod]
        public void Q01TestUniques()
        {
            var q = new Question01();
            // Should return true
            Assert.IsTrue(q.IsUniqueAscii("abc"));
            Assert.IsTrue(q.IsUniqueAscii(""));

            // Should return false
            Assert.IsFalse(q.IsUniqueAscii("aa"));
            Assert.IsFalse(q.IsUniqueAscii("abcdefghijklmnopqrstuvwxyza"));
        }

        [TestMethod]
        public void Q02Permutation()
        {
            var q = new Question02();
            Assert.IsTrue(q.ArePermutations("", ""));
            Assert.IsTrue(q.ArePermutations("ab", "ba"));
            Assert.IsTrue(q.ArePermutations("dog", "god"));

            Assert.IsFalse(q.ArePermutations("ab", "bb"));
            Assert.IsFalse(q.ArePermutations("a", ""));
        }
    }
}

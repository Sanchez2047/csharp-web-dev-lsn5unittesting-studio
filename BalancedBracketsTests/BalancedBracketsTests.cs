using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBracketReturnTrue1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void OnlyBracketReturnFalse2()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[]][[]]]][[]["));
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void OnlyBracketReturnTrue3()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[]][[]][][]"));
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void OnlyBracketReturnFalse4()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[][[[]][][["));
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void AmountOfBracketEven5()
        {
            BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[][[[]][][[");
            Assert.IsTrue(BalancedBrackets.BracketList.Count % 2 == 0);
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void OpeningBracketBeforeClosingBracket6()
        {
            BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[][[[]][][[");
            Assert.IsTrue(BalancedBrackets.BracketList.IndexOf('[') < BalancedBrackets.BracketList.IndexOf(']'));
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void IndexOfOpening7()
        {
            BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[][[[]][][[");
            Assert.AreEqual(0, BalancedBrackets.BracketList.IndexOf('['), .001);
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void IndexOfClosing8()
        {
            BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[][[[]][][[");
            Assert.AreEqual(1, BalancedBrackets.BracketList.IndexOf(']'), .001);
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void CountBracketList9()
        {
            BalancedBrackets.HasBalancedBrackets("[Launch]Code[[[]]][][[]][[]][][]");
            Assert.AreEqual(22, BalancedBrackets.BracketList.Count, .001);
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void TestCharArray10()
        {
            Assert.AreEqual(10, (BalancedBrackets.BracketsToBracketList("This[word]")).Length, .001);
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void TestBracketListRetention11()
        {
            Assert.AreEqual(0, BalancedBrackets.BracketList.Count, .001);
            BalancedBrackets.BracketList.Clear();
        }
        [TestMethod]
        public void CheckForBalanceBeforeNextSetOf12()
        {
            BalancedBrackets.BracketsToBracketList("[Launch]Code[[[]]][][[]][[]][][]");
            Assert.AreEqual(0, BalancedBrackets.NumberBalance(), .001);
            BalancedBrackets.BracketList.Clear();
        }
    }
}

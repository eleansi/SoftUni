using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;

namespace CustomLinkedList.Tests
{
    [TestClass]
    public class DynamicListTests
    {
        [TestMethod]
        public void Add_AtTheEndOfList_ShouldReturnTheSameIndex()
        {
            var dynamListTest = new DynamicList<int>();
            dynamListTest.Add(10);
            Assert.AreEqual(10, dynamListTest[dynamListTest.IndexOf(10)], "Does not add the right item at the end of the list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveElement_AtNegativeIndex()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.RemoveAt(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveElementAt_GraterThanCountIndex()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.RemoveAt(dynamicList.Count + 1);
        }

        [TestMethod]
        public void TestRemoveElements_AtGivenIndex()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            dynamicList.Add(66);
            dynamicList.Add(69);
            dynamicList.Add(42);

            dynamicList.RemoveAt(2);
            Assert.AreEqual(3, dynamicList.Count, "Returns wrong element after removal.");
        }

        [TestMethod]
        public void TestRemoveUnexistingElement_ReturnsIndex()
        {
            var dynamListTest = new DynamicList<int>();
            Assert.AreEqual(-1, dynamListTest.Remove(7));
        }

        [TestMethod]
        public void TestIfListContainsExistingElement()
        {
            var dynamListTest = new DynamicList<int>();
            dynamListTest.Add(2);
            Assert.IsTrue(dynamListTest.Contains(2));
        }

        [TestMethod]
        public void TestIfListContainsUnexistingElement()
        {
            var dynamListTest = new DynamicList<int>();
            Assert.IsFalse(dynamListTest.Contains(10));
        }
    }
}

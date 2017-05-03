using Algorithms.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Searching
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void IntSearch()
        {
            int[] ints = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // It should find each integer at the same index
            foreach (int number in ints)
            {
                Assert.IsTrue(number == BinarySearch.Rank(number, ints));
            }

            Assert.IsTrue(BinarySearch.Rank(100, ints) == -1);
        }

        [TestMethod]
        public void StringSearch()
        {
            string[] strings = { "A", "B", "C", "D" };

            Assert.IsTrue(BinarySearch.Rank("A", strings) == 0);
            Assert.IsTrue(BinarySearch.Rank("B", strings) == 1);
            Assert.IsTrue(BinarySearch.Rank("C", strings) == 2);
            Assert.IsTrue(BinarySearch.Rank("D", strings) == 3);

            Assert.IsTrue(BinarySearch.Rank("Nope", strings) == -1);
        }
    }
}

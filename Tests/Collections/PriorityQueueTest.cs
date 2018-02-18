using Algorithms.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Collections
{
    [TestClass]
    public class PriorityQueueTest
    {
        [TestMethod]
        public void PriorityQueueCreation()
        {
            PriorityQueue<int> intPQ = new PriorityQueue<int>();
            Assert.IsTrue(intPQ.Count == 0);
            Assert.IsTrue(intPQ.IsEmpty());

            int[] numbers = { 1, 2, 3, 4, 5 };

            // The default priority ordering is Greatest, so we should get back the largest
            // element in Peek()
            intPQ = new PriorityQueue<int>(numbers);
            Assert.IsTrue(intPQ.Peek() == 5);

            // Test using the Least priority ordering.
            intPQ = new PriorityQueue<int>(numbers, PriorityOrdering.Least);
            Assert.IsTrue(intPQ.Peek() == 1);

            PriorityQueue<string> stringPQ = new PriorityQueue<string>(50);
            Assert.IsTrue(stringPQ.Count == 0);
            Assert.IsTrue(stringPQ.IsEmpty());
        }

        [TestMethod]
        public void PriorityQueueOrdering()
        {
            string[] strings = { "A", "B", "C", "D", "E" };

            // Iterate through using Greatest ordering
            PriorityQueue<string> maxPQ = new PriorityQueue<string>(strings);
            int index = strings.Length - 1;
            while (!maxPQ.IsEmpty())
            {
                string max = maxPQ.Pop();
                Assert.AreEqual(strings[index], max);
                index--;
            }

            // Iterate through using Least ordering
            PriorityQueue<string> minPQ = new PriorityQueue<string>(strings, PriorityOrdering.Least);
            index = 0;
            while (!minPQ.IsEmpty())
            {
                string min = minPQ.Pop();
                Assert.AreEqual(strings[index], min);
                index++;
            }
        }
    }
}

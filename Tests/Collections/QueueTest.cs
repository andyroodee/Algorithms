using Algorithms.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void QueueCreation()
        {
            // Make sure a newly created queue is empty
            Queue<int> intQueue = new Queue<int>();
            Assert.IsTrue(intQueue.IsEmpty());
            Assert.IsTrue(intQueue.Count == 0);
        }

        [TestMethod]
        public void PeekPushPop()
        {
            // Make sure we can add items to a queue, and that the Count
            // updates appropriately.
            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Hello!");
            Assert.IsTrue(stringQueue.Count == 1);
            stringQueue.Enqueue("Goodbye!");
            Assert.IsTrue(stringQueue.Count == 2);

            // Make sure Peek() and Pop() work
            Assert.AreEqual(stringQueue.Peek(), "Hello!");
            Assert.IsTrue(stringQueue.Count == 2);
            Assert.AreEqual(stringQueue.Dequeue(), "Hello!");
            Assert.IsTrue(stringQueue.Count == 1);

            Assert.AreEqual(stringQueue.Dequeue(), "Goodbye!");
            Assert.IsTrue(stringQueue.IsEmpty());
        }

        [TestMethod]
        public void Iteration()
        {
            // Build up a queue and then make sure foreach iteration works.
            Queue<int> queue = new Queue<int>();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in numbers)
            {
                queue.Enqueue(num);
            }
            Assert.IsTrue(queue.Count == numbers.Length);

            int fifoIndex = 0;
            foreach (int val in queue)
            {
                Assert.AreEqual(val, numbers[fifoIndex]);
                fifoIndex++;
            }
        }
    }
}

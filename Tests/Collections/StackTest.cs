using Algorithms.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void StackCreation()
        {
            // Make sure a newly created stack is empty
            Stack<int> intStack = new Stack<int>();
            Assert.IsTrue(intStack.IsEmpty());
            Assert.IsTrue(intStack.Count == 0);
        }

        [TestMethod]
        public void PeekPushPop()
        { 
            // Make sure we can add items to a stack, and that the Count
            // updates appropriately.
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hello!");
            Assert.IsTrue(stringStack.Count == 1);
            stringStack.Push("Goodbye!");
            Assert.IsTrue(stringStack.Count == 2);

            // Make sure Peek() and Pop() work
            Assert.AreEqual(stringStack.Peek(), "Goodbye!");
            Assert.IsTrue(stringStack.Count == 2);
            Assert.AreEqual(stringStack.Pop(), "Goodbye!");
            Assert.IsTrue(stringStack.Count == 1);

            Assert.AreEqual(stringStack.Pop(), "Hello!");
            Assert.IsTrue(stringStack.IsEmpty());
        }

        [TestMethod]
        public void Iteration()
        {
            // Build up a stack and then make sure foreach iteration works.
            Stack<int> stack = new Stack<int>();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in numbers)
            {
                stack.Push(num);
            }
            Assert.IsTrue(stack.Count == numbers.Length);

            int lifoIndex = numbers.Length - 1;
            foreach (int val in stack)
            {
                Assert.AreEqual(val, numbers[lifoIndex]);
                lifoIndex--;
            }
        }
    }
}

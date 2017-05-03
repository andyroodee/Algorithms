using Algorithms.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Collections
{
    [TestClass]
    public class BagTest
    {
        [TestMethod]
        public void BagCreation()
        {
            // Make sure a newly created bag is empty
            Bag<int> intBag = new Bag<int>();
            Assert.IsTrue(intBag.IsEmpty());
            Assert.IsTrue(intBag.Count == 0);
        }

        [TestMethod]
        public void AddAndIteration()
        {
            Bag<int> bag = new Bag<int>();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in numbers)
            {
                bag.Add(num);
            }
            Assert.IsTrue(bag.Count == numbers.Count);
            
            // Each number we added should be found exactly once.
            foreach (int val in bag)
            {
                int index = numbers.BinarySearch(val);
                Assert.IsTrue(index >= 0);
                if (index >= 0)
                {
                    numbers.RemoveAt(index);
                }
            }
        }
    }
}

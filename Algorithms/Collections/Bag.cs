using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Collections
{
    public class Bag<Item> : IEnumerable<Item>
    {
        private Node first;

        private class Node
        {
            public Item Item { get; set; }
            public Node Next { get; set; }
        }

        public int Count
        { get; private set; }

        public bool IsEmpty()
        {
            return (Count == 0);
        }

        public void Add(Item item)
        {
            Node oldFirst = first;
            first = new Node { Item = item, Next = oldFirst };
            Count++;
        }

        private IEnumerator<Item> GetElements()
        {
            for (Node x = first; x != null; x = x.Next)
            {
                yield return x.Item;
            }
        }

        IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
        {
            return GetElements();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetElements();
        }
    }
}

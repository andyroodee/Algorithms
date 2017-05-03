using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Collections
{
    public class Bag<Item> : IEnumerable<Item>
    {
        private Node first;

        private class Node
        {
            public Item item;
            public Node next;
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
            first = new Node();
            first.item = item;
            first.next = oldFirst;
            Count++;
        }

        private IEnumerator<Item> GetElements()
        {
            for (Node x = first; x != null; x = x.next)
            {
                yield return x.item;
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

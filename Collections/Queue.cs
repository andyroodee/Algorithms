using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Collections
{
    public class Queue<Item> : IEnumerable<Item>
    {
        private Node first;
        private Node last;

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

        public void Enqueue(Item item)
        {
            Node oldLast = last;
            last = new Node();
            last.item = item;
            last.next = null;
            if (IsEmpty())
            {
                first = last;
            }
            else
            {
                oldLast.next = last;
            }
            Count++;
        }

        public Item Dequeue()
        {
            Item item = first.item;
            first = first.next;
            Count--;
            if (IsEmpty())
            {
                last = null;
            }
            return item;
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

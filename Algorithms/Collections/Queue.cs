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
            public Item Item { get; set; }
            public Node Next { get; set; }
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
            last = new Node { Item = item, Next = null };
            if (IsEmpty())
            {
                first = last;
            }
            else
            {
                oldLast.Next = last;
            }
            Count++;
        }

        public Item Dequeue()
        {
            Item item = first.Item;
            first = first.Next;
            Count--;
            if (IsEmpty())
            {
                last = null;
            }
            return item;
        }

        public Item Peek()
        {
            return first.Item;
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

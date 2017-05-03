using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Collections
{
    public class Stack<Item> : IEnumerable<Item>
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

        public void Push(Item item)
        {
            Node oldFirst = first;
            first = new Node();
            first.item = item;
            first.next = oldFirst;
            Count++;
        }

        public Item Pop()
        {
            Item item = first.item;
            first = first.next;
            Count--;
            return item;
        }

        public Item Peek()
        {
            return first.item;
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

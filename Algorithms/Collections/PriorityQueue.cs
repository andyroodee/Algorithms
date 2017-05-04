using System;
using System.Collections.Generic;

namespace Algorithms.Collections
{
    public enum PriorityOrdering
    {
        Least,
        Greatest
    }

    public class PriorityQueue<Item>
        where Item : IComparable<Item>
    {
        private Item[] heap = new Item[2];
        private PriorityOrdering ordering;

        public int Count
        { get; private set; }

        public PriorityQueue(PriorityOrdering ordering = PriorityOrdering.Greatest)
        {
            this.ordering = ordering;
        }
        
        public PriorityQueue(int initialCapacity, PriorityOrdering ordering = PriorityOrdering.Greatest)
            : this(ordering)
        {
            heap = new Item[initialCapacity + 1];
        }
        
        public PriorityQueue(ICollection<Item> keys, PriorityOrdering ordering = PriorityOrdering.Greatest)
            : this(ordering)
        {
            heap = new Item[keys.Count + 1];
            foreach (Item item in keys)
            {
                Insert(item);
            }
        }

        public void Insert(Item item)
        {
            Count++;
            if (Count >= heap.Length)
            {
                Resize(2 * heap.Length);
            }
            heap[Count] = item;
            Swim(Count);
        }

        public Item Peek()
        {
            return heap[1];
        }

        public Item Pop()
        {
            Item top = heap[1];
            Exchange(1, Count);
            heap[Count] = default(Item);
            Count--;
            Sink(1);
            if (Count > 0 && Count <= heap.Length / 4)
            {
                Resize(heap.Length / 2);
            }
            return top;
        }

        public bool IsEmpty()
        {
            return (Count == 0);
        }

        private bool Less(int i, int j)
        {
            switch (ordering)
            {
                case PriorityOrdering.Greatest:
                    return (heap[i].CompareTo(heap[j]) < 0);
                case PriorityOrdering.Least:
                    return (heap[i].CompareTo(heap[j]) > 0);
                default:
                    return (heap[i].CompareTo(heap[j]) < 0);
            }
        }

        private void Exchange(int i, int j)
        {
            Item temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;            
        }

        private void Swim(int k)
        {
            while (k > 1 && Less(k/2, k))
            {
                Exchange(k / 2, k);
                k /= 2;
            }
        }

        private void Sink(int k)
        {
            while (2 * k <= Count)
            {
                int j = 2 * k;
                if (j < Count && Less(j, j + 1))
                {
                    j++;
                }
                if (!Less(k, j))
                {
                    break;
                }
                Exchange(k, j);
                k = j;
            }
        }        

        private void Resize(int capacity)
        {
            Item[] newHeap = new Item[capacity];
            for (int i = 0; i <= Count; i++)
            {
                newHeap[i] = heap[i];
            }
            heap = newHeap;
        }
    }
}

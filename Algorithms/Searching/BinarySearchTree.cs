using System;

namespace Algorithms.Searching
{
    public class BinarySearchTree<Key, Value>
        where Key : IComparable<Key>
    {
        private Node root; // Root of BST

        private class Node
        {
            public Key Key
            { get; }

            public Value Val
            { get; set; }

            // Links to subtrees
            public Node Left
            { get; set; }

            public Node Right 
            { get; set; }

            // # of nodes in subtree rooted here
            public int Count
            { get; set; }

            public Node(Key key, Value val, int count)
            {
                Key = key;
                Val = val;
                Count = count;
            }
        }

        public int Size()
        {
            return Size(root);
        }

        private int Size(Node x)
        {
            if (x == null)
            {
                return 0;
            }
            return x.Count;
        }

        public bool TryGetValue(Key key, out Value val)
        {
            return TryGetValue(root, key, out val);
        }
        
        private bool TryGetValue(Node x, Key key, out Value val)
        {
            if (x == null)
            {
                val = default(Value);
                return false;
            }
            int cmp = key.CompareTo(x.Key);
            if (cmp < 0)
            {
                return TryGetValue(x.Left, key, out val);
            }

            if (cmp > 0)
            {
                return TryGetValue(x.Right, key, out val);
            }

            val = x.Val;
            return true;
        }

        public void Put(Key key, Value val)
        {
            root = Put(root, key, val);
        }

        private Node Put(Node x, Key key, Value val)
        {
            if (x == null)
            {
                return new Node(key, val, 1);
            }
            int cmp = key.CompareTo(x.Key);
            if (cmp < 0)
            {
                x.Left = Put(x.Left, key, val);
            }
            else if (cmp > 0)
            {
                x.Right = Put(x.Right, key, val);
            }
            else
            {
                x.Val = val;
            }
            x.Count = Size(x.Left) + Size(x.Right) + 1;
            return x;            
        }
    }
}

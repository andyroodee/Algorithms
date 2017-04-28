using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Collections
{
    public class Bag<Item> : IEnumerable<Item>
    {
        IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

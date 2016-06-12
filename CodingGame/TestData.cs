using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingGame
{
    public class TestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = 0; i < 8; i++)
            {
                yield return new object[] { i, i + 10 };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
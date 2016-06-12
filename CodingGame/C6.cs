using System.Collections.Generic;

namespace CodingGame
{
    public class MyStruct
    {
        public MyStruct()
        {
            Dictionary = new Dictionary<int, int>
            {
                [1] = 10
            };
        }

        public Dictionary<int, int> Dictionary { get; protected set; }

        public int Count { get; set; }
    }
}
using Xunit;

namespace CodingGame
{
    public class CodingGame
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void Test(int index, int height)
        {
            var indexMountain = 0;
            for (int i = 0, max = 0; i < 8; i++)
            {
                var heightMountain = int.Parse(height.ToString());
                if (max < heightMountain)
                {
                    max = heightMountain;
                    indexMountain = i;
                }

                // represents the height of one mountain, from 9 to 0.
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            Assert.Equal(index, indexMountain);
        }

        public int MyFunction() => 6;
       
        private class MyClass
        {
        }
    }
}
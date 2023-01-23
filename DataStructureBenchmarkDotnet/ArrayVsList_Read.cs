using BenchmarkDotNet.Attributes;

namespace MyBenchmarks
{
    [SimpleJob]
    public class ArrayVsList_Read
    {
        private int[] testArray;
        private List<int> testList;

        public ArrayVsList_Read()
        {
            testList = new List<int>(5000000);
            var random = new Random(12345);
            for (var i = 0; i < testList.Capacity; i++)
            {
                testList.Add(random.Next(5000));
            }
            testArray = testList.ToArray();
        }

        [Benchmark]
        public void ListFor()
        {
            long chk = 0;
            for (int i = 0; i < testList.Count; i++)
            {
                chk += testList[i];
            }
        }

        [Benchmark]
        public void ArrayFor()
        {
            long chk = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                chk += testArray[i];
            }
        }

        [Benchmark]
        public void ListForEach()
        {
            long chk = 0;
            foreach (int i in testList)
            {
                chk += i;
            }
        }

        [Benchmark]
        public void ArrayForEach()
        {
            long chk = 0;
            foreach (int i in testArray)
            {
                chk += i;
            }
        }
    }
}
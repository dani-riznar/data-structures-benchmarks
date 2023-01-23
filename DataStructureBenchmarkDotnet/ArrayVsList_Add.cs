using BenchmarkDotNet.Attributes;

namespace MyBenchmarks
{
    [SimpleJob(iterationCount: 1, warmupCount: 10, invocationCount: 1000, launchCount: 1)]
    public class ArrayVsList_Add
    {
        [Params(1000, 10000, 100000)]
        public int n;
        private int[] testArray;
        private List<int> testList;

        public ArrayVsList_Add()
        {
        }

        [IterationSetup]
        public void IterationSetup()
        {
            testArray = new int[n];
            testList = new List<int>();
        }

        [IterationCleanup]
        public void IterationCleanup()
        {
            testArray = null;
            testList.Clear();
        }

        [Benchmark]
        public void ArrayAdd()
        {
            for (var i = 0; i < n; i++)
                testArray[i] = 1;
        }

        [Benchmark]
        public void ArrayAddConcat()
        {
            for (var i = 0; i < n; i++)
                testArray.Concat(new int[] { 1 });
        }

        [Benchmark]
        public void ListAdd()
        {
            for (var i = 0; i < n; i++)
                testList.Add(1);
        }
    }
}
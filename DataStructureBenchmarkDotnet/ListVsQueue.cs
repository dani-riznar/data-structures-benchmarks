using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    [SimpleJob(iterationCount: 1, warmupCount: 10, invocationCount: 10, launchCount: 1)]
    public class ListVsQueue
    {
        [Params(1000, 10000, 100000)]
        public int n;
        private List<int> testList;
        private Queue<int> testQueue;

        public ListVsQueue()
        {
        }

        [IterationSetup]
        public void IterationSetup()
        {
            testList = new List<int>();
            testQueue = new Queue<int>();
        }

        [IterationCleanup]
        public void IterationClenaup()
        {
            testList.Clear();
            testQueue.Clear();
        }

        [Benchmark]
        public void ListAddRemove()
        {
            for (var i = 0; i < n; i++)
                testList.Add(1);

            while (testList.Count > 0)
                testList.RemoveAt(0);
        }

        [Benchmark]
        public void QueueAddRemove()
        {
            for(var i = 0; i < n; i++)
                testQueue.Enqueue(1);

            while (testQueue.Count > 0)
                testQueue.Dequeue();
        }
    }
}
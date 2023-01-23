using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    [SimpleJob(iterationCount: 1, warmupCount: 10, invocationCount: 10, launchCount: 1)]
    public class ListVsStack
    {
        [Params(1000, 10000, 100000)]
        public int n;
        private List<int> testList;
        private Stack<int> testStack;

        public ListVsStack()
        {
        }

        [IterationSetup]
        public void IterationSetup()
        {
            testList = new List<int>();
            testStack = new Stack<int>();
        }

        [IterationCleanup]
        public void IterationClenaup()
        {
            testList.Clear();
            testStack.Clear();
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
        public void StackAddRemove()
        {
            for(var i = 0; i < n; i++)
                testStack.Push(1);

            while (testStack.Count > 0)
                testStack.Pop();
        }
    }
}
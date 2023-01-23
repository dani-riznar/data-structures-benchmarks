using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    [SimpleJob(iterationCount:1,warmupCount:10,invocationCount:1000,launchCount:1)]
    public class ListVsLinkedList
    {
        [Params(1000,10000,100000)]
        public int n;
        private List<int> testList;
        private LinkedList<int> testLinkedList;
        private LinkedListNode<int> middleNode;

        public ListVsLinkedList()
        {
            testList = new List<int>();
            testLinkedList = new LinkedList<int>();
        }

        [IterationSetup]
        public void IterationSetup()
        {
            for (var j = 0; j < n; j++)
            {
                testList.Add(j);
                var temp = testLinkedList.AddLast(j);
                if (j == n / 2)
                    middleNode = temp;
            }
        }

        [IterationCleanup]
        public void IterationCleanup()
        {
            testList.Clear();
            testLinkedList.Clear();
        }

        [Benchmark]
        public void ListPrepend()
        {
            testList.Insert(0, 1);
        }

        [Benchmark]
        public void LinkedListPrepend()
        {
            testLinkedList.AddFirst(1);
        }

        [Benchmark]
        public void ListInsert()
        {
            testList.Insert(testList.Count / 2, 1);
        }

        [Benchmark]
        public void LinkedListInsert()
        {
            testLinkedList.AddBefore(middleNode, 1);
        }

        [Benchmark]
        public void ListRemoveAt()
        {
            if (testList.Count > 0)
                testList.RemoveAt(0);
        }

        [Benchmark]
        public void LinkedListRemoveAt()
        {
            if (testLinkedList.Count > 0)
                testLinkedList.RemoveFirst();
        }
    }
}
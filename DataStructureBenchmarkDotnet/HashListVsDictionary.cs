using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace DataStructureBenchmarkDotnet
{
    [SimpleJob(iterationCount: 1, warmupCount: 10, invocationCount: 10, launchCount: 1)]
    public class HashListVsDictionary
    {
        [Params(1000,10000,100000)]
        public int n;
        private HashSet<int> hashSet;
        private Dictionary<int, int> dictionary;
        private Random random;

        public HashListVsDictionary()
        {
        }

        [IterationSetup]
        public void IterationSetup()
        {
            random=new Random(12345);
            hashSet=new HashSet<int>();
            dictionary=new Dictionary<int, int>();

            for (var i = 0; i < n; i++)
            {
                hashSet.Add(random.Next(5000));
                dictionary[i]=random.Next(5000);
            }
        }

        [IterationCleanup]
        public void IterationCleanup()
        {
            hashSet.Clear();
            dictionary.Clear();
        }

        [Benchmark]
        public void HashListAccess()
        {
            hashSet.Contains(random.Next(1, n - 3));
        }

        [Benchmark]
        public void DictionaryAccess()
        {
            var temp=dictionary[random.Next(1, n - 3)];
        }

    }
}

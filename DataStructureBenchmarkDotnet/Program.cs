// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using DataStructureBenchmarkDotnet;
using MyBenchmarks;

var summary = BenchmarkRunner.Run<ListVsStack>();

//var array = new[] { 1, 2, 3 };
//array.Concat(new[] { 4 });
//array.Concat(new[] { 5 });

//var list = new List<int> {1,2,3};
//list.Add(4);
//list.Add(5);
//list.RemoveAt(0);

//var linkedList = new LinkedList<int>();
//linkedList.AddFirst(new LinkedListNode<int>(5));

//var queue = new Queue<int>();
//queue.First();
//queue.Last();

//var hashSet = new HashSet<int>();
//hashSet.Add(1);
//hashSet.Add(2);

//var dictionary = new Dictionary<int, string>();
//dictionary.Add(1, "test1");
//dictionary.Add(2, "test2");
//dictionary.Add(3, "test3");

//var stack = new Stack<int>();
//stack.Push(1);
//stack.Pop();
//stack.Push(4);
//stack.Push(6);
//stack.Push(9);
//stack.Push(3);
//stack.Pop();

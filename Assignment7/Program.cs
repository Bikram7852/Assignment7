using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListOperations();
            //StackOperations();
            //QueueOperations();
            //HashtableOperations();
        }

        private static void HashtableOperations()
        {
            Hashtable hashTable1 = new Hashtable();

            hashTable1.Add(1, 10);
            hashTable1.Add(2, "Hello");
            hashTable1.Add(3, true);

            Console.WriteLine("Contents of Hash Table 1:");
            foreach (DictionaryEntry entry in hashTable1)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine("--------------------------");

            hashTable1.Remove(2);

            Console.WriteLine("After removing the element contents of Hash Table 1:");
            foreach (DictionaryEntry entry in hashTable1)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine("--------------------------");

            Hashtable hashTable2 = new Hashtable(hashTable1);

            Console.WriteLine("\nContents of Hash Table 2:");
            foreach (DictionaryEntry entry in hashTable2)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.ReadLine();
        }

        private static void QueueOperations()
        {
            Console.WriteLine("Enqueue Operation:");
            Queue s = new Queue(6);
            s.Enqueue(1);
            s.Enqueue("Hello");
            s.Enqueue(3.5f);
            s.Enqueue(20000d);
            s.Enqueue(true);
            s.Enqueue('s');
            foreach (var x in s)
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Dequeue Operation:");
            //s.Dequeue();
            //foreach (var x in s)
            //{
            //    Console.WriteLine(x);
            //}

            Console.WriteLine("--------------------------");
            Console.WriteLine("Copy Operation:");
            Queue s1 = new Queue(s);
            foreach (object item in s1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Clear Operation:");
            s.Clear();
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void StackOperations()
        {
            Console.WriteLine("Push Operation:");
            Stack s = new Stack(6);
            s.Push(1);
            s.Push("Hello");
            s.Push(3.5f);
            s.Push(20000d);
            s.Push(true);
            s.Push('s');
            foreach (var x in s)
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Pop Operation:");
            //s.Pop();
            //foreach (var x in s)
            //{
            //    Console.WriteLine(x);
            //}

            Console.WriteLine("--------------------------");
            Console.WriteLine("Copy Operation:");
            Stack s1 = new Stack(s);
            foreach (object item in s1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Clear Operation:");
            s.Clear();
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void ArrayListOperations()
        {
            ArrayList arr = new ArrayList(10);
            arr.Add(1);
            arr.Add(2.5f);
            arr.Add(3000000d);
            arr.Add("4");
            arr.Add(5);
            arr.Add(true);
            arr.Add(6.5f);
            arr.Add(7000000d);
            arr.Add("8");
            arr.Add(false);
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");

            //bool a = arr.Contains(5);
            //if (a)
            //{
            //    arr.Remove(a);
            //}
            //else
            //{
            //    Console.WriteLine("Item not found.");
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------");

            Console.WriteLine("Elements in the Array:");
            object[] o = new object[arr.Count];
            arr.CopyTo(o, 0);
            foreach (var item in o)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine("Only int elements of the Array:");
            int i = 0;
            int[] a = new int[o.Length];
            foreach (dynamic j in o)
            {
                //Console.WriteLine(i.GetType());
                if (j.GetType() == typeof(int))
                {
                    a[i] = j;
                }
                else
                {
                    i++;
                }
            }
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");

            Console.WriteLine("Sorted the elements of the Array:");
            Array.Sort(a);
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");

            Console.WriteLine("Reverse the elements of the sorted Array:");

            Array.Reverse(a);
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace DemoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            var numbers2 = new List<int>() { 1, 2, 3, 4, 5 };

            numbers2.Add(10);
            numbers2.Add(29);

            numbers2.AddRange(new int[3] { 4, 5, 6 });

            foreach (var n in numbers2)
                Console.WriteLine(n);

            Console.WriteLine("Index of 4" + numbers2.IndexOf(4));
            Console.WriteLine("Last index of 4" + numbers2.LastIndexOf(4));

            Console.WriteLine("Jumlah data " + numbers2.Count);

            numbers2.Remove(4);
            foreach (var n in numbers2)
                Console.WriteLine(n);

            for (int i = 0; i< numbers2.Count; i++)
            {
                if (numbers2[i] == 4)
                    numbers2.Remove(numbers2[i]);
            }

            foreach (var n in numbers2)
                Console.WriteLine(n);

            numbers2.Clear();

            Console.WriteLine("DIHAPUS");

            foreach (var n in numbers2)
                Console.WriteLine(n);

            Console.WriteLine("HABIS");
        }
    }
}

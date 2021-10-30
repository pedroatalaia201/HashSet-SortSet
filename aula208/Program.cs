using System;
using System.Collections.Generic;

namespace aula208
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));
            //OUTPUT: true ou false;

            //lembrando que o mesmo não tem posições, por isso o foreach;
            foreach(string prod in set)
            {
                Console.WriteLine(prod);
            }


            SortedSet<int> sort = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> sort2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.WriteLine();

            //union:

            SortedSet<int> sort3 = new SortedSet<int>(sort);
            sort3.UnionWith(sort2);

            PrintCollections(sort3);

            //intersection:
            SortedSet<int> sort4 = new SortedSet<int>(sort);
            sort4.IntersectWith(sort2);

            PrintCollections(sort4);

            //diference:
            SortedSet<int> sort5 = new SortedSet<int>(sort);
            sort5.ExceptWith(sort2);
            PrintCollections(sort5);
        }

        //IEnumerable é uma interface implementada por todas as coleções básicas do System.Collections
        static void PrintCollections<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }
    }
}

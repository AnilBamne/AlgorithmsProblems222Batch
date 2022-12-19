
using System;

namespace AlgorithmAndDSPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure and algorithm practice programs");
            Console.WriteLine("Choose option\n1 Binary search for word\n2 Permutations of word\n3 Merge sort");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    DemoPrograms.BinarySearch();
                    break;
                case 2:
                    Console.WriteLine("Enter the word to compute permutations");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    DemoPrograms.Permute(str, 0, n - 1);
                    break;
            }
            
        }
    }
}
